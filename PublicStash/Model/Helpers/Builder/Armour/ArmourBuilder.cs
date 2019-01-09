using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Armours;

namespace PathOfExile.Model.Internal
{
    internal class ArmourBuilder : IJsonBuilder<Armour>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        private IDictionary<String, IJsonBuilder<Armour>> Builders { get; }

        public ArmourBuilder()
        {
            Parser = new ArmourParser();
            Builders = new Dictionary<String, IJsonBuilder<Armour>>
            {
                ["BodyArmours"] = new BodyArmourBuilder(),
                ["Boots"] = new BootsBuilder(),
                ["Gloves"] = new GlovesBuilder(),
                ["Helmets"] = new HelmetBuilder(),
                ["Shields"] = new ShieldBuilder()
            };
        }

        public IBuilder<JObject, Armour> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public Armour Build()
        {
            return Builders.TryGetValue(Parser.Parse(JObject), out var builder)
                ? builder.For(JObject).Build()
                : null;
        }
    }
}