using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class Context : AbstractXmlElement
    {
        [XmlElement("RepeatContext")]
        public RepeatContext? RepeatContext { get; set; }
        [XmlElement("LogicContext")]
        public LogicContext? LogicContext { get; set; }

        public override void ToXml()
        {
            Console.WriteLine("        <Context>");
            RepeatContext?.ToXml();
            LogicContext?.ToXml();
            Console.WriteLine("        </Context>");
        }
    }
}
