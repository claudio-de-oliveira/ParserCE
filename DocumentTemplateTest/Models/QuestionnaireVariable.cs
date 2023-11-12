using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class QuestionnaireVariable : AbstractXmlElement
    {
        [XmlAttribute("Name")]
        public string? Name { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"            <QuestionnaireVariable Name =\"{Name}\"/>");
        }
    }
}
