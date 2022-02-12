using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    internal class JsonParser : IJsonParser
    {
        public string Parse(JObject obj)
        {
            return obj["extended"]?["category"]?.ToObject<string>() ?? "";
        }
    }
}
