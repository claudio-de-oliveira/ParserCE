using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

using DocumentTemplateTest.Data;
using DocumentTemplateTest.Models;

using System.Text.Json.Nodes;
using System.Xml;

if (args.Length != 2)
{
    Console.WriteLine($"Modo de usar: DocumentTemplateTest <arquivo.docx> <arquivo.json>");
    return;
}

try
{
    using WordprocessingDocument mainDocument = WordprocessingDocument.Open(args[0], false);

    AbstractXmlElement? dictionary = Dictionary.ReadFromDocx(mainDocument);
    if (dictionary is null)
    {
        Console.WriteLine($"O arquivo \"{args[0]}\" é inválido ou não contém um dicionário.");
        Console.WriteLine($"O programa não pode continuar!");
        return;
    }

    string text = File.ReadAllText(args[1]);

    JsonNode json = JsonNode.Parse(text)!;
    if (json is null)
    {
        Console.WriteLine($"O arquivo \"{args[1]}\" é inválido.");
        Console.WriteLine($"O programa não pode continuar!");
        return;
    }

    var data = Response.Create(json);
    if (data is null || data.Data is null || data.Data.QuestionnaireJSON is null)
    {
        Console.WriteLine($"O arquivo \"{args[1]}\" não contém as informações requeridas.");
        Console.WriteLine($"O programa não pode continuar!");
        return;
    }

    var variables = data.Data.QuestionnaireJSON.Variables;

    MainDocumentPart? mainDocumentPart = mainDocument.MainDocumentPart;

    var body = CreateNewBody(mainDocumentPart!.Document.Body!, variables.Dictionary);

    using WordprocessingDocument newDocument = WordprocessingDocument.CreateFromTemplate(args[0]);

    newDocument.MainDocumentPart!.Document.Body!.RemoveAllChildren();
    newDocument.MainDocumentPart!.Document.Body = body;

    string newFileName = $"{Path.GetDirectoryName(args[0])}\\abc_{Path.GetFileName(args[0])}";

    newDocument.Clone(newFileName);

    Console.WriteLine();
    Console.WriteLine($"O arquivo \"{newFileName}\" foi gerado com sucesso!");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex}");
}
catch (XmlException ex)
{
    Console.WriteLine($"XML Error at line {ex.LineNumber}: {ex.Message}");
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Unsupported operation: {ex}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Modo de usar: DocumentTemplateTest <arquivo.docx> <arquivo.json>");
}
finally
{

}

static DocumentFormat.OpenXml.Wordprocessing.Body CreateNewBody(DocumentFormat.OpenXml.Wordprocessing.Body body, Dictionary<string, DocumentTemplateTest.Data.Variable> variables)
{
    List<OpenXmlElement> ret = new();
    int i = 0;

    var clone = (DocumentFormat.OpenXml.Wordprocessing.Body)body.CloneNode(false);

    clone.RemoveAllChildren();

    while (i < body.ChildElements.Count)
    {
        var xmlElement1 = body.ChildElements.ElementAt(i);

        clone.AppendChild(Descende(xmlElement1, variables));

        i++;
    }

    return clone;
}


static OpenXmlElement Descende(OpenXmlElement xmlElement, Dictionary<string, DocumentTemplateTest.Data.Variable> variables)
{
    int i = 0;

    var clone = xmlElement.CloneNode(false);

    if (xmlElement.ChildElements.Count > 0)
    {
        clone.RemoveAllChildren();

        while (i < xmlElement.ChildElements.Count)
        {
            var xmlElement1 = xmlElement.ChildElements.ElementAt(i);

            if (i < xmlElement.ChildElements.Count + 3 && xmlElement1 is DocumentFormat.OpenXml.Wordprocessing.Run run1 && run1.InnerText == "{")
            {
                var xmlElement2 = xmlElement.ChildElements.ElementAt(i + 1);
                if (xmlElement2 is DocumentFormat.OpenXml.Wordprocessing.Run run2)
                {
                    var xmlElement3 = xmlElement.ChildElements.ElementAt(i + 2);
                    if (xmlElement3 is DocumentFormat.OpenXml.Wordprocessing.Run run3 && run3.InnerText == "}")
                    {
                        var key = run2.InnerText;

                        var run = (OpenXmlElement)run2.Clone();

                        run.RemoveAllChildren();

                        if (variables.ContainsKey(key))
                        {
                            Console.WriteLine($"Substituindo \"{key}\" por \"{variables[key].GetValue()}\"");

                            foreach (var child in run2.ChildElements)
                            {
                                if (child is DocumentFormat.OpenXml.Wordprocessing.Text)
                                {
                                    var text = (DocumentFormat.OpenXml.Wordprocessing.Text)child.Clone();
                                    text.Text = variables[key].GetValue();
                                    run.AppendChild(text);
                                }
                                else
                                    run.AppendChild((OpenXmlElement)child.Clone());
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Não sei como processar: {key}");

                            foreach (var child in run2.ChildElements)
                            {
                                if (child is DocumentFormat.OpenXml.Wordprocessing.Text)
                                {
                                    var text = (DocumentFormat.OpenXml.Wordprocessing.Text)child.Clone();
                                    text.Text = $"Não sei como processar: {key}";
                                    run.AppendChild(text);
                                }
                                else
                                    run.AppendChild((OpenXmlElement)child.Clone());
                            }
                        }

                        clone.AppendChild(run);

                        i += 2; // Dois eliminados
                    }
                    else
                    {
                        clone.AppendChild(Descende(xmlElement1, variables));
                        clone.AppendChild(Descende(xmlElement2, variables));
                        clone.AppendChild(Descende(xmlElement3, variables));
                    }
                }
                else
                {
                    clone.AppendChild(Descende(xmlElement1, variables));
                    clone.AppendChild(Descende(xmlElement2, variables));
                }
            }
            else
                clone.AppendChild(Descende(xmlElement1, variables));

            i++;
        }
    }

    return clone;
}