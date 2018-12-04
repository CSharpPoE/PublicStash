using System;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Items.Helpers.Parser
{
    class CurrencyParser : IJsonParser
    {
        public string Parse(JObject obj)
        {
            return obj["typeLine"].ToObject<String>();
        }
    }
}