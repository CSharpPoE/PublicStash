using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Weapons.TwoHanded;

namespace PathOfExile.Model.Internal
{
    internal class TwoHandedBuilder : IJsonBuilder<TwoHandedWeapon>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        IDictionary<String, Type> TwoHandedTypes { get; }

        public TwoHandedBuilder()
        {
            Parser = new TwoHandedParser();
            TwoHandedTypes = AttributeHelper.CreateTypeDictionary<TwoHandedAttribute>(new Dictionary<String, Type>());
        }

        public IBuilder<JObject, TwoHandedWeapon> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public TwoHandedWeapon Build()
        {
            if (TwoHandedTypes.TryGetValue(Parser.Parse(JObject), out var twoHandedClass))
            {
                return (TwoHandedWeapon) JObject.ToObject(twoHandedClass);
            }

            return null;
        }
    }
}