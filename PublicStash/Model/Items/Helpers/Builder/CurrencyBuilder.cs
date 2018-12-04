using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Helpers;
using PathOfExile.Model.Items.Helpers.Parser;

namespace PathOfExile.Model.Items.Currency
{
    internal class CurrencyBuilder : IJsonBuilder<Currency>
    {
        private const String ExaltedOrb = "Exalted Orb";
        private const String ChaosOrb = "Chaos Orb";

        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        IDictionary<String, Type> CurrencyTypes { get; }

        private Stopwatch watch = new Stopwatch();

        public CurrencyBuilder()
        {
            Parser = new CurrencyParser();
            CurrencyTypes = CreateTypeDictionary(new Dictionary<String, Type>());
        }

        private static IDictionary<String, Type> CreateTypeDictionary(IDictionary<String, Type> typeDict)
        {
            foreach ( var assembly in AppDomain.CurrentDomain.GetAssemblies().AsParallel() )
            {
                foreach ( var currency in GetTypesWithCurrencyAttribute(assembly).AsParallel() )
                {
                    var value = currency.GetCustomAttribute<CurrencyAttribute>()?.Value;
                    if ( !String.IsNullOrEmpty(value) )
                    {
                        typeDict.Add(value, currency);
                    }
                }
            }
            return typeDict;
        }

        public IBuilder<JObject, Currency> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public Currency Build()
        {
            if (CurrencyTypes.TryGetValue(Parser.Parse(JObject), out var currency))
            {
                return (Currency) JObject.ToObject(currency);
            }

            return null;
        }

        static IEnumerable<Type> GetTypesWithCurrencyAttribute(Assembly assembly) => assembly.GetTypes()
            .Where(type => type.GetCustomAttributes(typeof(CurrencyAttribute), true).Length > 0);
    }
}