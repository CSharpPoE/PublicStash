using PathOfExile.Model.Items.Gems.Support;

namespace PathOfExile.Model.Internal
{
    internal class SupportGemBuilder : TBuilder<SupportGem>
    {
        public SupportGemBuilder() : base(new TypeLineParser(), AttributeHelper.Index<SupportGemAttribute>())
        {
        }
    }
}