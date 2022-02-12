using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    class ItemConstructor : IJsonConstructor
    {
        private IParser<JObject> Parser { get; }
        private IJsonBuilder<UnspecifiedItem> UnspecifiedItemBuilder { get; }

        private IDictionary<string, IJsonBuilder<Item>> Builders { get; }

        public ItemConstructor()
        {
            Parser = new JsonParser();

            UnspecifiedItemBuilder = new UnspecifiedItemBuilder();
            Builders = new Dictionary<string, IJsonBuilder<Item>>
            {
                ["currency"] = new CurrencyBuilder(),

                ["cards"] = new CardBuilder(),
                
                // Accessories
                ["accessories"] = new AccessoryBuilder(),
                //["rings"] = new RingBuilder(),
                //["belts"] = new BeltBuilder(),
                //["amulets"] = new AmuletBuilder(),
                
                ["weapons"] = new WeaponBuilder(),
                
                ["armour"] = new ArmourBuilder(),
                
                ["gems"] = new GemBuilder(),
                
                ["maps"] = new MapBuilder(),
                
                ["jewels"] = new JewelBuilder(),
                
                ["quivers"] = new QuiverBuilder(), 
            };
        }

        public Item ConstructFrom(JObject obj)
        {
            var res = Builders.TryGetValue(Parser.Parse(obj), out var builder)
                ? builder.For(obj).Build()
                : UnspecifiedItemBuilder.For(obj).Build();

            //if (res == null)
            //{
            //    var str = $"{obj["extended"]["category"]} - {obj["baseType"]}";
            //    Tmp.Test1.Add(str);
            //}
            return res;
        }
    }
}