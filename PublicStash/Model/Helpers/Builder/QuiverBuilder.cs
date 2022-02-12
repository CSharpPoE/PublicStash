using PathOfExile.Model.Items.Quivers;

namespace PathOfExile.Model.Internal
{
    internal class QuiverBuilder : TBuilder<Quiver>
    {
        public QuiverBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<QuiverAttribute>())
        {
        }
    }
}