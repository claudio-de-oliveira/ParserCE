using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class DefaultFormat : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"        <DefaultFormat>{Value}</DefaultFormat>");
        }
    }
}
