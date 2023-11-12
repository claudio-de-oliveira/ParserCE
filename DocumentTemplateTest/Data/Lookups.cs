using System.Text.Json.Nodes;

namespace DocumentTemplateTest.Data
{
    public class Lookups : AbstractJsonElement
    {
        public static Lookups? Create(JsonNode? json)
        {
            if (json is null)
                return null;

            var node = new Lookups();

            return node;
        }
    }
}
