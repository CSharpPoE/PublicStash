using PathOfExile.Model.Items.Armours.Gloves;

namespace PathOfExile.Model.Internal
{
    internal class GlovesBuilder : TBuilder<Gloves>
    {
        public GlovesBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<GlovesAttribute>())
        {
        }
    }
}