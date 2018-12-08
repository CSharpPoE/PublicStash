using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal class ItemConverter : JsonConverter
    {
        private static readonly IConstructor<JObject, Item> ItemConstructor = new ItemConstructor();

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return ItemConstructor.ConstructFrom(JObject.Load(reader));
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Item);
    }
}