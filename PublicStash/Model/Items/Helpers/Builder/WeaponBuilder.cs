using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Weapons;

namespace PathOfExile.Model.Internal
{
    internal class WeaponBuilder : IJsonBuilder<Weapon>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        private IDictionary<String, IJsonBuilder<Weapon>> Builders { get; }

        public WeaponBuilder()
        {
            Parser = new WeaponParser();

            Builders = new Dictionary<String, IJsonBuilder<Weapon>>
            {
                ["OneHandWeapons"] = new OneHandedBuilder(),
                ["TwoHandWeapons"] = new TwoHandedBuilder()
            };
        }

        public IBuilder<JObject, Weapon> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public Weapon Build()
        {
            return Builders.TryGetValue(Parser.Parse(JObject), out var builder)
                ? builder.For(JObject).Build()
                : null;
        }
    }
}