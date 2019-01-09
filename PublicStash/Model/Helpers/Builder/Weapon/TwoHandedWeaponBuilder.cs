using PathOfExile.Model.Items.Weapons.TwoHanded;

namespace PathOfExile.Model.Internal
{
    internal class TwoHandedWeaponBuilder : TBuilder<TwoHandWeapon>
    {
        public TwoHandedWeaponBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<TwoHandWeaponAttribute>())
        {
        }
    }
}