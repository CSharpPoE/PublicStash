using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    internal class JsonParser : IJsonParser
    {
        private const String IconPattern = @"http://web.poecdn.com/image/Art/2DItems/(?<itemType>\w+)";
        private const String IconGroup = "itemType";

        public string Parse(JObject obj)
        {
            return Regex.Match(obj["icon"].ToObject<String>(), IconPattern).Groups[IconGroup].Value;
        }

        public string Parse(object obj) => Parse((JObject) obj);
    }
}
