using System.Text.Json.Nodes;

namespace DocumentTemplateTest.Data
{
    public class Functions : AbstractJsonElement
    {
        public static Functions? Create(JsonNode? json)
        {
            if (json is null)
                return null;

            var node = new Functions();

            return node;
        }
    }
}
