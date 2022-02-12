using PathOfExile.Model.Items.Cards;

namespace PathOfExile.Model.Internal
{
    internal class CardBuilder : TBuilder<Card>
    {
        public CardBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<CardAttribute>())
        {
        }
    }
}