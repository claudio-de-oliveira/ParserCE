
using System.Text.Json.Nodes;

namespace DocumentTemplateTest.Data
{
    public class SubTemplate : AbstractJsonElement
    {
        public static SubTemplate? Create(JsonNode? json)
        {
            if (json is null)
                return null;

            var node = new SubTemplate();

            return node;
        }
    }
}
