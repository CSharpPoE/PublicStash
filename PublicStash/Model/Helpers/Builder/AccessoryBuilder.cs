using PathOfExile.Model.Items.Accessories;

namespace PathOfExile.Model.Internal
{
    internal class AccessoryBuilder : TBuilder<Accessory>
    {
        public AccessoryBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<AccessoryAttribute>())
        {
        }
    }
}