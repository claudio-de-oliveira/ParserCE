using System.Text.Json.Nodes;

namespace DocumentTemplateTest.Data
{
    public class ChildTemplate : AbstractJsonElement
    {
        public static ChildTemplate? Create(JsonNode? json)
        {
            if (json is null)
                return null;

            var node = new ChildTemplate();

            return node;
        }
    }
}
