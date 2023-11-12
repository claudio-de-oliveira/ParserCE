using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class Prompt : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"        <Prompt>{Value}</Prompt>");
        }
    }
}
