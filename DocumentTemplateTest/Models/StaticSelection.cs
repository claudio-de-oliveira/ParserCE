using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class StaticSelection : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"        <StaticSelection>{Value}</StaticSelection>");
        }
    }
}
