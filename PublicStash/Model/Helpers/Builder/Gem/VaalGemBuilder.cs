using PathOfExile.Model.Items.Gems.Vaal;

namespace PathOfExile.Model.Internal
{
    internal class VaalGemBuilder : TBuilder<VaalGem>
    {
        public VaalGemBuilder() : base(new TypeLineParser(), AttributeHelper.Index<VaalGemAttribute>())
        {
        }
    }
}