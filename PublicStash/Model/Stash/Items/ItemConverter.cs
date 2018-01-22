using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model
{
    internal class ItemConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            dynamic obj = JObject.Load(reader);

            switch (obj.category)
            {
                case JValue value:
                    switch ((String) value)
                    {
                        #region Currency

                        case "currency":
                            return obj.ToObject<Currency>();

                        #endregion

                        #region Flask

                        case "flasks":
                            return obj.ToObject<Flask>();

                        #endregion

                        #region Gem

                        case "gems":
                            return obj.ToObject<Gem>();

                        #endregion

                        #region Jewel

                        case "jewels":
                            return obj.ToObject<Jewel>();

                        #endregion

                        #region Divination

                        case "cards":
                            return obj.ToObject<Divination>();

                        #endregion

                        #region Map

                        case "maps":
                            return obj.ToObject<Map>();

                        //case var fragment when IsExactlyType(Fragment.BASES, (String) obj.typeLine):
                        //    return fragment.ToObject<Fragment>();

                        #endregion


                        #region Legacy

                        case "leaguestones":
                            return obj.ToObject<Leaguestone>();

                        #endregion
                    }
                    break;

                case JObject o:
                    switch ((String) o.First.First[0])
                    {
                        #region League

                        #region Abyss

                        case "abyss":
                            return obj.ToObject<AbyssJewel>();

                        #endregion

                        #region Harbinger

                        case "piece":
                            return obj.ToObject<Piece>();

                        #endregion

                        #region Breach

                        //case var blessing when IsExactlyType(Blessing.BASES, (String) obj.typeLine):
                        //    return blessing.ToObject<Blessing>();

                        //case var breachstone when IsExactlyType(Breachstone.BASES, (String) obj.typeLine):
                        //    return breachstone.ToObject<Breachstone>();

                        #endregion

                        #region Essence

                        //case var essence when IsPartOfType(Essence.BASES, (String) obj.typeLine):
                        //    return essence.ToObject<Essence>();

                        #endregion

                        #region Prophecy

                        //case var prophecy when IsExactlyType(Prophecy.BASES, (String) obj.typeLine):
                        //    return prophecy.ToObject<Prophecy>();

                        #endregion

                        #region Talisman

                        //case var talisman when IsPartOfType(Talisman.BASES, (String) obj.typeLine):
                        //    return talisman.ToObject<Talisman>();

                        #endregion

                        #endregion

                        #region Jewellery

                        case "amulet":
                            return obj.ToObject<Amulet>();

                        case "ring":
                            return obj.ToObject<Ring>();

                        case "belt":
                            return obj.ToObject<Belt>();

                        #endregion

                        #region Armour

                        case "chest":
                            return obj.ToObject<Chest>();

                        case "helmet":
                            return obj.ToObject<Helmet>();

                        case "gloves":
                            return obj.ToObject<Gloves>();

                        case "boots":
                            return obj.ToObject<Boots>();

                        case "shield":
                            return obj.ToObject<Shield>();

                        case "quiver":
                            return obj.ToObject<Quiver>();

                        #endregion

                        #region Weapon

                        case "bow":
                            return obj.ToObject<Bow>();

                        case "claw":
                            return obj.ToObject<Claw>();

                        case "dagger":
                            return obj.ToObject<Dagger>();

                        case "oneaxe":
                            return obj.ToObject<OneHandedAxe>();

                        case "onemace":
                            return obj.ToObject<OneHandedMace>();

                        case "onesword":
                            return obj.ToObject<OneHandedSword>();

                        case "sceptre":
                            return obj.ToObject<Sceptre>();

                        case "staff":
                            return obj.ToObject<Staff>();

                        case "twoaxe":
                            return obj.ToObject<TwoHandedAxe>();

                        case "twomace":
                            return obj.ToObject<TwoHandedMace>();

                        case "twosword":
                            return obj.ToObject<TwoHandedSword>();

                        case "wand":
                            return obj.ToObject<Wand>();

                        case "rod":
                            return obj.ToObject<FishingRod>();

                        #endregion
                    }
                    break;
            }

            return obj.ToObject<UnspecifiedItem>();
        }

        //private static bool IsPartOfType(IEnumerable<String> list, String obj) =>
        //    list.Any(e => obj.IndexOf(e, StringComparison.Ordinal) != -1);

        //private static bool IsExactlyType(IEnumerable<String> list, String obj) =>
        //    list.Contains(obj);

        public override bool CanConvert(Type objectType) => objectType == typeof(Item);
    }
}