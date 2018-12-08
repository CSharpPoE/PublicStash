using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Internal
{
    class WeaponParser : IJsonParser
    {
        private const String IconPattern = @"http://web.poecdn.com/image/Art/2DItems/Weapons/(?<weaponType>\w+)";
        private const String IconGroup = "weaponType";

        public string Parse(JObject obj)
        {
            return Regex.Match(obj["icon"].ToObject<String>(), IconPattern).Groups[IconGroup].Value;
        }
    }
}