using PathOfExile.Model.Items.Armours.Helmets;

namespace PathOfExile.Model.Internal
{
    internal class HelmetBuilder : TBuilder<Helmet>
    {
        public HelmetBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<HelmetAttribute>())
        {
        }
    }
}