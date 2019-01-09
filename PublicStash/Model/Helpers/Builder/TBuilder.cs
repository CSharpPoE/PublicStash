using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items;

namespace PathOfExile.Model.Internal
{
    internal class TBuilder<TItem> : IJsonBuilder<TItem> where TItem : Item
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }
        private IDictionary<String, Type> Types { get; }

        protected TBuilder(IParser<JObject> parser, IDictionary<String, Type> typeDict)
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

            return null;
        }
    }
}