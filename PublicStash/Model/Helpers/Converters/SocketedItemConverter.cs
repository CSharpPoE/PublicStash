using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal class SocketedItemConverter : JsonConverter
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
            return JArray.Load(reader).Select(e => ItemConstructor.ConstructFrom((JObject) e));
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(IEnumerable<Item>);
    }
}