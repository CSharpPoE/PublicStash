using PathOfExile.Model.Items.Gems.Active;

namespace PathOfExile.Model.Internal
{
    internal class ActiveGemBuilder : TBuilder<ActiveGem>
    {
        public ActiveGemBuilder() : base(new TypeLineParser(), AttributeHelper.Index<ActiveGemAttribute>())
        {
        }
    }
}