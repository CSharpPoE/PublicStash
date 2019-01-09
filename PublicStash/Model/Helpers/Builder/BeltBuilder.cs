using PathOfExile.Model.Items.Belts;

namespace PathOfExile.Model.Internal
{
    internal class BeltBuilder : TBuilder<Belt>
    {
        public BeltBuilder() : base(new TypeLineParser(), AttributeHelper.Index<BeltAttribute>())
        {
        }
    }
}