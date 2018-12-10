using PathOfExile.Model.Items.Currencies;

namespace PathOfExile.Model.Internal
{
    internal class CurrencyBuilder : TBuilder<Currency>
    {
        public CurrencyBuilder() : base(new TypeLineParser(), AttributeHelper.Index<CurrencyAttribute>())
        {
        }
    }
}