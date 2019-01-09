using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    class ItemConstructor : IJsonConstructor
    {
        private IParser<JObject> Parser { get; }
        private IJsonBuilder<UnspecifiedItem> UnspecifiedItemBuilder { get; }

        private IDictionary<String, IJsonBuilder<Item>> Builders { get; }

        public ItemConstructor()
        {
            Parser = new JsonParser();

            UnspecifiedItemBuilder = new UnspecifiedItemBuilder();
            Builders = new Dictionary<String, IJsonBuilder<Item>>
            {
                ["Currency"] = new CurrencyBuilder(),
                ["Divination"] = new CardBuilder(),
                ["Rings"] = new RingBuilder(),
                ["Amulets"] = new AmuletBuilder(),
                ["Weapons"] = new WeaponBuilder(),
                ["Armours"] = new ArmourBuilder(),
                ["Gems"] = new GemBuilder(),
                ["Belts"] = new BeltBuilder(),
                ["Jewels"] = new JewelBuilder(),
                ["Quivers"] = new QuiverBuilder()
            };
        }

        public Item ConstructFrom(JObject obj)
        {
            return Builders.TryGetValue(Parser.Parse(obj), out var builder)
                ? builder.For(obj).Build()
                : UnspecifiedItemBuilder.For(obj).Build();
        }
    }
}