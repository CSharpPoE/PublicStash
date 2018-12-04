
using System;

namespace PathOfExile.Model.Items.Helpers
{
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
}
