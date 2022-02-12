using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;
using PathOfExile.Model.Items.Armours;
using PathOfExile.Model.Items.Maps;

namespace PathOfExile.Model.Internal
{
    public static class Tmp
    {
        public static HashSet<string> Test1 = new HashSet<string>();
        public static HashSet<string> Test2 = new HashSet<string>();
        public static HashSet<string> Test3 = new HashSet<string>();
        public static HashSet<string> Test4 = new HashSet<string>();
        public static HashSet<string> Test5 = new HashSet<string>();
        public static HashSet<string> Test6 = new HashSet<string>();
        public static HashSet<string> Test7 = new HashSet<string>();
        public static HashSet<string> Test8 = new HashSet<string>();
    }

    internal class TBuilder<TItem> : IJsonBuilder<TItem> where TItem : Item
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }
        private IDictionary<string, Type> Types { get; }

        protected TBuilder(IParser<JObject> parser, IDictionary<string, Type> typeDict)
        {
            Parser = parser;
            Types = typeDict;
        }

        public IBuilder<JObject, TItem> For(JObject obj)
        {
            JObject = obj;
            return this;
        }
        
        public TItem Build()
        {
            if (Types.TryGetValue(Parser.Parse(JObject), out var tClass))
            {
                return (TItem) JObject.ToObject(tClass);
            }

            //if(typeof(TItem).Name == typeof(Map).Name)
            //{
            //    var tmp = Parser.Parse(JObject);
            //    if (tmp.Contains("Map") && tmp.Contains("Blighted"))
            //    {
            //        Tmp.Test1.Add("\""+tmp + "\"");
            //        var f = string.Join($",{Environment.NewLine}", Tmp.Test1.OrderBy(s => s));
            //    }

            //    if (tmp.Contains("Map") && tmp.Contains("Blight-ravaged"))
            //    {
            //        Tmp.Test2.Add("\"" + tmp + "\"");
            //        var f = string.Join($",{Environment.NewLine}", Tmp.Test2.OrderBy(s => s));
            //    }

            //    if (tmp.Contains("Scarab"))
            //    {
            //        Tmp.Test3.Add("\"" + tmp + "\"");
            //        var f = string.Join($",{Environment.NewLine}", Tmp.Test3.OrderBy(s => s));
            //    }

            //    if (tmp.Contains("Breachstone"))
            //    {
            //        Tmp.Test4.Add("\"" + tmp + "\"");
            //        var f = string.Join($",{Environment.NewLine}", Tmp.Test4.OrderBy(s => s));
            //    }

            //    if (tmp.Contains("Emblem"))
            //    {
            //        Tmp.Test5.Add("\"" + tmp + "\"");
            //        var f = string.Join($",{Environment.NewLine}", Tmp.Test5.OrderBy(s => s));
            //    }

            //    if (tmp.Contains("Invitation"))
            //    {
            //        Tmp.Test6.Add("\"" + tmp + "\"");
            //        var f = string.Join($",{Environment.NewLine}", Tmp.Test6.OrderBy(s => s));
            //    }

            //    Tmp.Test8.Add(tmp);
            //}

            return null;
        }
    }
}