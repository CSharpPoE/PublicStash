using PathOfExile.Model.Items.Armours;

namespace PathOfExile.Model.Internal
{
    internal class ArmourBuilder : TBuilder<Armour>
    {
        public ArmourBuilder() : base(new ArmourParser(), AttributeHelper.Index<ArmourAttribute>())
        {
        }
    }
}