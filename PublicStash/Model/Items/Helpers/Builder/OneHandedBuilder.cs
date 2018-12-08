using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Weapons.OneHanded;

namespace PathOfExile.Model.Internal
{
    internal class OneHandedBuilder : IJsonBuilder<OneHandedWeapon>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        IDictionary<String, Type> OneHandedTypes { get; }

        public OneHandedBuilder()
        {
            Parser = new OneHandedParser();
            OneHandedTypes = AttributeHelper.CreateTypeDictionary<OneHandedAttribute>(new Dictionary<String, Type>());
        }

        public IBuilder<JObject, OneHandedWeapon> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public OneHandedWeapon Build()
        {
            if (OneHandedTypes.TryGetValue(Parser.Parse(JObject), out var oneHandedClass))
            {
                return (OneHandedWeapon) JObject.ToObject(oneHandedClass);
            }

            return null;
        }
    }
}