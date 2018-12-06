using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Currencies;

namespace PathOfExile.Model.Internal
{
    internal class CurrencyBuilder : IJsonBuilder<Currency>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        IDictionary<String, Type> CurrencyTypes { get; }

        public CurrencyBuilder()
        {
            Parser = new CurrencyParser();
            CurrencyTypes = AttributeHelper.CreateTypeDictionary<CurrencyAttribute>(new Dictionary<String, Type>());
        }

        public IBuilder<JObject, Currency> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public Currency Build()
        {
            if (CurrencyTypes.TryGetValue(Parser.Parse(JObject), out var currencyClass))
            {
                return (Currency) JObject.ToObject(currencyClass);
            }

            return null;
        }
    }
}