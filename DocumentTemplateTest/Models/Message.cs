using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class Message : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"        <Message>{Value}</Message>");
        }
    }
}
