using PathOfExile.Model.Items.Jewels;

namespace PathOfExile.Model.Internal
{
    internal class JewelBuilder : TBuilder<Jewel>
    {
        public JewelBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<JewelAttribute>())
        {
        }
    }
}