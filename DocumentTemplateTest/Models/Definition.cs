using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class Definition : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"        <Definition>{Value}</Definition>");
        }
    }
}
