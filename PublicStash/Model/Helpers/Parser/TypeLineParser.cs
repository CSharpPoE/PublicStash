using System;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    class TypeLineParser : IParser<JObject>
    {
        public string Parse(JObject obj)
        {
            return obj["typeLine"].ToObject<String>();
        }
    }
}
