using System.Xml.Serialization;

namespace DocumentTemplateTest.Models
{
    public class DatastoreItem : AbstractXmlElement
    {
        [XmlAttribute(AttributeName = "itemID", Namespace = "\"http://schemas.openxmlformats.org/officeDocument/2006/customXml\"")]
        public string? ItemID { get; set; }

        public override void ToXml()
        {
            throw new NotImplementedException();
        }
    }
}
