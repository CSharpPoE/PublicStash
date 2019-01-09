using PathOfExile.Model.Items.Armours.Boots;

namespace PathOfExile.Model.Internal
{
    internal class BootsBuilder : TBuilder<Boots>
    {
        public BootsBuilder() : base(new BootsParser(),
            AttributeHelper.Index<BootsAttribute>())
        {
        }
    }
}