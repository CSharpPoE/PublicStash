using System;
using Newtonsoft.Json;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    class SocketableConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Socketable);
    }
}
