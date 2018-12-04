using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Currency;
using PathOfExile.Model.Items.Helpers.Parser;

namespace PathOfExile.Model.Items
{
    class ItemConstructor : IJsonConstructor
    {
        private IParser<JObject> Parser { get; }
        private IDictionary<String, IJsonBuilder<Item>> Builders { get; }

        private JObject JObject{ get; set; }

        public ItemConstructor()
        {
            Parser = new JsonParser();

            Builders = new Dictionary<String, IJsonBuilder<Item>>
            {
                ["Currency"] = new CurrencyBuilder()
            };
        }

        public IConstructor<JObject, Item> For(JObject obj)
        {
            JObject = obj;
            return this;
        }
        
        public Item Construct()
        {
            return Builders.TryGetValue(Parser.Parse(JObject), out var builder) ? builder.For(JObject).Build() : null;
        }
    }
}
