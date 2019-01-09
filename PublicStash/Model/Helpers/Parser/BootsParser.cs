using System;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    class BootsParser : IParser<JObject>
    {
        private const String TwoToned = "Two-Toned Boots";

        private const String StrDex = nameof(StrDex);
        private const String StrInt = nameof(StrInt);
        private const String DexInt = nameof(DexInt);

        public string Parse(JObject obj)
        {
            var result = obj["typeLine"].ToObject<String>();
            if (result != TwoToned) return result;

            // [0] = level, [1] = str/dex, [2] = dex/int
            var requirements = obj["requirements"].ToObject<Item.Requirement[]>();
            switch (requirements[1].Name + requirements[2].Name)
            {
                case StrDex: return NameMapping.ArmourEvasionTwoTonedBoots;
                case StrInt: return NameMapping.ArmourEnergyShieldTwoTonedBoots;
                case DexInt: return NameMapping.EnergyShieldEvasionTwoTonedBoots;
                default: return null;
            }

            //return obj["typeLine"].ToObject<String>();
        }
    }
}