using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class RepeatContext : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"            <RepeatContext>{Value}</RepeatContext>");
        }
    }
}
