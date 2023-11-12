using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class Guidance : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"        <Guidance>{Value}</Guidance>");
        }
    }
}
