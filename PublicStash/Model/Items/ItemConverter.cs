using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Currency;

namespace PathOfExile.Model.Items
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
            return ItemConstructor.For(JObject.Load(reader)).Construct();
            //if (obj.category?.gems != null) return obj.ToObject<Gem.Gem>();
            //if (obj.category?.currency != null) return obj.ToObject<Currency.Currency>();
            //if (obj.category?.jewels != null) return obj.ToObject<Jewel.Jewel>();
            //if (obj.category?.cards != null) return obj.ToObject<Card>();
            //if (obj.category?.flasks != null) return obj.ToObject<Flask.Flask>();
            //if (obj.category?.maps != null) return obj.ToObject<Map.Map>();
            //if (obj.category?.leaguestones != null) return obj.ToObject<Leaguestone>();

            //var jobj = (JObject) obj.category;
            //if (jobj["monsters"] != null) return obj.ToObject<Beast.Beast>();

            //var item = (String) jobj.First.First[0];
            //switch (item)
            //{
            //    case "abyss": return obj.ToObject<AbyssJewel>();
            //    case "piece": return obj.ToObject<Piece>();
            //    case "amulet": return obj.ToObject<Amulet>();
            //    case "ring": return obj.ToObject<Ring>();
            //    case "belt": return obj.ToObject<Belt>();
            //    case "chest": return obj.ToObject<Chest>();
            //    case "helmet": return obj.ToObject<Helmet>();
            //    case "gloves": return obj.ToObject<Gloves>();
            //    case "boots": return obj.ToObject<Boots>();
            //    case "shield": return obj.ToObject<Shield>();
            //    case "quiver": return obj.ToObject<Quiver>();
            //    case "bow": return obj.ToObject<Bow>();
            //    case "claw": return obj.ToObject<Claw>();
            //    case "dagger": return obj.ToObject<Dagger>();
            //    case "oneaxe": return obj.ToObject<OneHandedAxe>();
            //    case "onemace": return obj.ToObject<OneHandedMace>();
            //    case "onesword": return obj.ToObject<OneHandedSword>();
            //    case "sceptre": return obj.ToObject<Sceptre>();
            //    case "staff": return obj.ToObject<Staff>();
            //    case "twoaxe": return obj.ToObject<TwoHandedAxe>();
            //    case "twomace": return obj.ToObject<TwoHandedMace>();
            //    case "twosword": return obj.ToObject<TwoHandedSword>();
            //    case "wand": return obj.ToObject<Wand>();
            //    case "rod": return obj.ToObject<FishingRod>();
            //}

            //return obj.ToObject<UnspecifiedItem>();
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(Item);
    }
}