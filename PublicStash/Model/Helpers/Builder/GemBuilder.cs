using PathOfExile.Model.Items.Gems;

namespace PathOfExile.Model.Internal
{
    internal class GemBuilder : TBuilder<Gem>
    {
        public GemBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<GemAttribute>())
        {
        }
    }
}