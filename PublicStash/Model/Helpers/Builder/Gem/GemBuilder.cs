using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Gems;

namespace PathOfExile.Model.Internal
{
    internal class GemBuilder : IJsonBuilder<Gem>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        private IJsonBuilder<Gem> DefaultGemBuilder { get; }
        private IDictionary<String, IJsonBuilder<Gem>> Builders { get; }

        public GemBuilder()
        {
            Parser = new GemParser();

            DefaultGemBuilder = new ActiveGemBuilder();
            Builders = new Dictionary<String, IJsonBuilder<Gem>>
            {
                ["Support"] = new SupportGemBuilder(),
                ["VaalGems"] = new VaalGemBuilder()
            };
        }

        public IBuilder<JObject, Gem> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public Gem Build()
        {
            return Builders.TryGetValue(Parser.Parse(JObject), out var builder)
                ? builder.For(JObject).Build()
                : DefaultGemBuilder.For(JObject).Build();
        }
    }
}