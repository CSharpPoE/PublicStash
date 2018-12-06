using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal class ItemConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private static readonly IConstructor<JObject, Item> ItemConstructor = new ItemConstructor();

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return ItemConstructor.Construct(JObject.Load(reader));
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Item);
    }
}