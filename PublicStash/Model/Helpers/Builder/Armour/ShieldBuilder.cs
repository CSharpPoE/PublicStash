using PathOfExile.Model.Items.Armours.Shields;

namespace PathOfExile.Model.Internal
{
    internal class ShieldBuilder : TBuilder<Shield>
    {
        public ShieldBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<ShieldAttribute>())
        {
        }
    }
}