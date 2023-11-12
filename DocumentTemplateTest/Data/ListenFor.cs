using System.Text.Json.Nodes;

namespace DocumentTemplateTest.Data
{
    public class ListenFor : AbstractJsonElement
    {
        public static ListenFor? Create(JsonNode? json)
        {
            if (json is null)
                return null;

            var node = new ListenFor();

            return node;
        }
    }
}
