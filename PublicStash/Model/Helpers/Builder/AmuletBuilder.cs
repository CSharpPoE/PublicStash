using PathOfExile.Model.Items.Amulets;

namespace PathOfExile.Model.Internal
{
    internal class AmuletBuilder : TBuilder<Amulet>
    {
        public AmuletBuilder() : base(new TypeLineParser(), AttributeHelper.Index<AmuletAttribute>())
        {
        }
    }
}