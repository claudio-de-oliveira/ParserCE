using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class LogicContext : AbstractXmlElement
    {
        [XmlText]
        public string? Value { get; set; }

        public override void ToXml()
        {
            Console.WriteLine($"            <LogicContext>{Value}</LogicContext>");
        }
    }
}
