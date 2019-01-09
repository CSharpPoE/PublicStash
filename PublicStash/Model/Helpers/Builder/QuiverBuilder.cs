using PathOfExile.Model.Items.Quivers;

namespace PathOfExile.Model.Internal
{
    internal class QuiverBuilder : TBuilder<Quiver>
    {
        public QuiverBuilder() : base(new TypeLineParser(), AttributeHelper.Index<QuiverAttribute>())
        {
        }
    }
}