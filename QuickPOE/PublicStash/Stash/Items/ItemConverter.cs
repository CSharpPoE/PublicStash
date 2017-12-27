using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PublicStash.Model
{
    internal class ItemConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        #region Test

        //public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        //    JsonSerializer serializer)
        //{
        //    dynamic obj = JObject.Load(reader);

        //    switch ( obj )
        //    {
        //        #region Gem

        //        case var gem when IsExactlyType(Gem.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Divination

        //        case var divination when IsExactlyType(Divination.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region League

        //        #region Abyss

        //        case var abyssjewel when IsPartOfType(AbyssJewel.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Legacy

        //        case var leaguestone when IsPartOfType(Leaguestone.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Breach

        //        case var blessing when IsExactlyType(Blessing.BASES, (String) obj.typeLine):
        //            return null;

        //        case var breachstone when IsExactlyType(Breachstone.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Essence

        //        case var essence when IsPartOfType(Essence.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Prophecy

        //        case var prophecy when IsExactlyType(Prophecy.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #endregion

        //        #region Jewel

        //        case var jewel when IsPartOfType(Jewel.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Jewellery

        //        case var amulet when IsPartOfType(Amulet.BASES, (String) obj.typeLine):
        //            return null;

        //        case var ring when IsPartOfType(Ring.BASES, (String) obj.typeLine):
        //            return null;

        //        case var belt when IsPartOfType(Belt.BASES, (String) obj.typeLine):
        //            return null;

        //        case var talisman when IsPartOfType(Talisman.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Flask

        //        case var flask when IsPartOfType(Flask.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Armour

        //        case var bodyarmour when IsPartOfType(Body.BASES, (String) obj.typeLine):
        //            return null;

        //        case var helmet when IsPartOfType(Helmet.BASES, (String) obj.typeLine):
        //            return null;

        //        case var gloves when IsPartOfType(Gloves.BASES, (String) obj.typeLine):
        //            return null;

        //        case var boots when IsPartOfType(Boots.BASES, (String) obj.typeLine):
        //            return null;

        //        case var shield when IsPartOfType(Shield.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Weapon

        //        case var bow when IsPartOfType(Bow.BASES, (String) obj.typeLine):
        //            return null;

        //        case var claw when IsPartOfType(Claw.BASES, (String) obj.typeLine):
        //            return null;

        //        case var dagger when IsPartOfType(Dagger.BASES, (String) obj.typeLine):
        //            return null;

        //        case var onehandedaxe when IsPartOfType(OneHandedAxe.BASES, (String) obj.typeLine):
        //            return null;

        //        case var onehandedmace when IsPartOfType(OneHandedMace.BASES, (String) obj.typeLine):
        //            return null;

        //        case var onehandedsword when IsPartOfType(OneHandedSword.BASES, (String) obj.typeLine):
        //            return null;

        //        case var sceptre when IsPartOfType(Sceptre.BASES, (String) obj.typeLine):
        //            return null;

        //        case var staff when IsPartOfType(Staff.BASES, (String) obj.typeLine):
        //            return null;

        //        case var twohandedaxe when IsPartOfType(TwoHandedAxe.BASES, (String) obj.typeLine):
        //            return null;

        //        case var twohandedmace when IsPartOfType(TwoHandedMace.BASES, (String) obj.typeLine):
        //            return null;

        //        case var twohandedsword when IsPartOfType(TwoHandedSword.BASES, (String) obj.typeLine):
        //            return null;

        //        case var wand when IsPartOfType(Wand.BASES, (String) obj.typeLine):
        //            return null;

        //        case var quiver when IsPartOfType(Quiver.BASES, (String) obj.typeLine):
        //            return null;

        //        case var fishingrod when IsPartOfType(FishingRod.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Currency

        //        case var currency when IsExactlyType(Currency.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        #region Map

        //        case var map when IsPartOfType(Map.BASES, (String) obj.typeLine):
        //            return null;

        //        case var fragment when IsExactlyType(Fragment.BASES, (String) obj.typeLine):
        //            return null;

        //        #endregion

        //        default:
        //            return obj.ToObject<UnspecifiedItem>();
        //    }
        //}

        #endregion

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            dynamic obj = JObject.Load(reader);

            switch (obj)
            {
                #region Gem

                case var gem when IsExactlyType(Gem.BASES, (String) obj.typeLine):
                    return gem.ToObject<Gem>();

                #endregion

                #region Divination

                case var divination when IsExactlyType(Divination.BASES, (String) obj.typeLine):
                    return divination.ToObject<Divination>();

                #endregion

                #region League

                #region Abyss

                case var abyssjewel when IsPartOfType(AbyssJewel.BASES, (String) obj.typeLine):
                    return abyssjewel.ToObject<AbyssJewel>();

                #endregion

                #region Legacy

                case var leaguestone when IsPartOfType(Leaguestone.BASES, (String) obj.typeLine):
                    return leaguestone.ToObject<Leaguestone>();

                #endregion

                #region Breach

                case var blessing when IsExactlyType(Blessing.BASES, (String) obj.typeLine):
                    return blessing.ToObject<Blessing>();

                case var breachstone when IsExactlyType(Breachstone.BASES, (String) obj.typeLine):
                    return breachstone.ToObject<Breachstone>();

                #endregion

                #region Essence

                case var essence when IsPartOfType(Essence.BASES, (String) obj.typeLine):
                    return essence.ToObject<Essence>();

                #endregion

                #region Prophecy

                case var prophecy when IsExactlyType(Prophecy.BASES, (String) obj.typeLine):
                    return prophecy.ToObject<Prophecy>();

                #endregion

                #region Talisman

                case var talisman when IsPartOfType(Talisman.BASES, (String) obj.typeLine):
                    return talisman.ToObject<Talisman>();

                #endregion

                #endregion

                #region Jewel

                case var jewel when IsPartOfType(Jewel.BASES, (String) obj.typeLine):
                    return jewel.ToObject<Jewel>();

                #endregion

                #region Jewellery

                case var amulet when IsPartOfType(Amulet.BASES, (String) obj.typeLine):
                    return amulet.ToObject<Amulet>();

                case var ring when IsPartOfType(Ring.BASES, (String) obj.typeLine):
                    return ring.ToObject<Ring>();

                case var belt when IsPartOfType(Belt.BASES, (String) obj.typeLine):
                    return belt.ToObject<Belt>();

                #endregion

                #region Flask

                case var flask when IsPartOfType(Flask.BASES, (String) obj.typeLine):
                    return flask.ToObject<Flask>();

                #endregion

                #region Armour

                case var bodyarmour when IsPartOfType(Body.BASES, (String) obj.typeLine):
                    return bodyarmour.ToObject<Body>();

                case var helmet when IsPartOfType(Helmet.BASES, (String) obj.typeLine):
                    return helmet.ToObject<Helmet>();

                case var gloves when IsPartOfType(Gloves.BASES, (String) obj.typeLine):
                    return gloves.ToObject<Gloves>();

                case var boots when IsPartOfType(Boots.BASES, (String) obj.typeLine):
                    return boots.ToObject<Boots>();

                case var shield when IsPartOfType(Shield.BASES, (String) obj.typeLine):
                    return shield.ToObject<Shield>();

                #endregion

                #region Weapon

                case var bow when IsPartOfType(Bow.BASES, (String) obj.typeLine):
                    return bow.ToObject<Bow>();

                case var claw when IsPartOfType(Claw.BASES, (String) obj.typeLine):
                    return claw.ToObject<Claw>();

                case var dagger when IsPartOfType(Dagger.BASES, (String) obj.typeLine):
                    return dagger.ToObject<Dagger>();

                case var onehandedaxe when IsPartOfType(OneHandedAxe.BASES, (String) obj.typeLine):
                    return onehandedaxe.ToObject<OneHandedAxe>();

                case var onehandedmace when IsPartOfType(OneHandedMace.BASES, (String) obj.typeLine):
                    return onehandedmace.ToObject<OneHandedMace>();

                case var onehandedsword when IsPartOfType(OneHandedSword.BASES, (String) obj.typeLine):
                    return onehandedsword.ToObject<OneHandedSword>();

                case var sceptre when IsPartOfType(Sceptre.BASES, (String) obj.typeLine):
                    return sceptre.ToObject<Sceptre>();

                case var staff when IsPartOfType(Staff.BASES, (String) obj.typeLine):
                    return staff.ToObject<Staff>();

                case var twohandedaxe when IsPartOfType(TwoHandedAxe.BASES, (String) obj.typeLine):
                    return twohandedaxe.ToObject<TwoHandedAxe>();

                case var twohandedmace when IsPartOfType(TwoHandedMace.BASES, (String) obj.typeLine):
                    return twohandedmace.ToObject<TwoHandedMace>();

                case var twohandedsword when IsPartOfType(TwoHandedSword.BASES, (String) obj.typeLine):
                    return twohandedsword.ToObject<TwoHandedSword>();

                case var wand when IsPartOfType(Wand.BASES, (String) obj.typeLine):
                    return wand.ToObject<Wand>();

                case var quiver when IsPartOfType(Quiver.BASES, (String) obj.typeLine):
                    return quiver.ToObject<Quiver>();

                case var fishingrod when IsPartOfType(FishingRod.BASES, (String) obj.typeLine):
                    return fishingrod.ToObject<FishingRod>();

                #endregion

                #region Currency

                case var currency when IsExactlyType(Currency.BASES, (String) obj.typeLine):
                    return currency.ToObject<Currency>();

                #endregion

                #region Map

                case var map when IsPartOfType(Map.BASES, (String) obj.typeLine):
                    return map.ToObject<Map>();

                case var fragment when IsExactlyType(Fragment.BASES, (String) obj.typeLine):
                    return fragment.ToObject<Fragment>();

                #endregion

                default:
                    return obj.ToObject<UnspecifiedItem>();
            }
        }

        private static bool IsPartOfType(IEnumerable<String> list, String obj) =>
            list.Any(e => obj.IndexOf(e, StringComparison.Ordinal) != -1);

        private static bool IsExactlyType(IEnumerable<String> list, String obj) =>
            list.Contains(obj);

        public override bool CanConvert(Type objectType) => objectType == typeof(AbstractItem);
    }
}