using System;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    class CardParser : IJsonParser
    {
        public string Parse(JObject obj)
        {
            return obj["typeLine"].ToObject<String>();
        }
    }
}