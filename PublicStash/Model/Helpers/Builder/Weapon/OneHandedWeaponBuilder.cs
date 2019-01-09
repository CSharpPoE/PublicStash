using PathOfExile.Model.Items.Weapons.OneHanded;

namespace PathOfExile.Model.Internal
{
    internal class OneHandedWeaponBuilder : TBuilder<OneHandWeapon>
    {
        public OneHandedWeaponBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<OneHandWeaponAttribute>())
        {
        }
    }
}