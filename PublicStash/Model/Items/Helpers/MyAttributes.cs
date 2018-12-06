using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PathOfExile.Model.Internal
{
    public static class AttributeHelper
    {
        internal static IDictionary<String, Type> CreateTypeDictionary<T>(IDictionary<String, Type> typeDict)
            where T : ItemAttribute
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().AsParallel())
            {
                foreach (var type in assembly.GetTypes().AsParallel())
                {
                    var value = type.GetCustomAttribute<T>()?.Value;
                    if (!String.IsNullOrEmpty(value))
                    {
                        typeDict.Add(value, type);
                    }
                }
            }

            return typeDict;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    internal class ItemAttribute : Attribute
    {
        public String Value { get; }

        protected ItemAttribute(String value)
        {
            Value = value;
        }
    }

    internal class CurrencyAttribute : ItemAttribute
    {
        public CurrencyAttribute(string value) : base(value)
        {
        }
    }

    internal class OrbAttribute : CurrencyAttribute
    {
        public OrbAttribute(string value) : base(value)
        {
        }
    }

    internal class BlessingAttribute : CurrencyAttribute
    {
        public BlessingAttribute(string value) : base(value)
        {
        }
    }

    internal class ProphecyAttribute : CurrencyAttribute
    {
        public ProphecyAttribute(string value) : base(value)
        {
        }
    }

    internal class CardAttribute : ItemAttribute
    {
        public CardAttribute(string value) : base(value)
        {
        }
    }
}