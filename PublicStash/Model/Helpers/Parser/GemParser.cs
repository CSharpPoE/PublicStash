using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    class GemParser : IJsonParser
    {
        private const String IconPattern = @"http://web.poecdn.com/image/Art/2DItems/Gems/(?<gemType>\w+)";
        private const String IconGroup = "gemType";

        public string Parse(JObject obj)
        {
            return Regex.Match(obj["icon"].ToObject<String>(), IconPattern).Groups[IconGroup].Value;
        }
    }
}