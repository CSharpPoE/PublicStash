using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    public class ArmourParser : BaseTypeParser
    {
        private const string TwoToned = "Two-Toned Boots";

        private const string StrDex = nameof(StrDex);
        private const string StrInt = nameof(StrInt);
        private const string DexInt = nameof(DexInt);

        public override string Parse(JObject obj)
        {
            var result = base.Parse(obj);
            if (result != TwoToned) return result;

            // [0] = level, [1] = str/dex, [2] = dex/int
            var requirements = obj["requirements"].ToObject<Requirement[]>();
            return (requirements[1].Name + requirements[2].Name) switch
            {
                StrDex => NameMapping.ArmourEvasionTwoTonedBoots,
                StrInt => NameMapping.ArmourEnergyShieldTwoTonedBoots,
                DexInt => NameMapping.EnergyShieldEvasionTwoTonedBoots,
                _ => null
            };
        }
    }
}