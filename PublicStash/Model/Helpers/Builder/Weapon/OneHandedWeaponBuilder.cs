using PathOfExile.Model.Items.Weapons.OneHanded;

namespace PathOfExile.Model.Internal
{
    internal class OneHandedWeaponBuilder : TBuilder<OneHandedWeapon>
    {
        public OneHandedWeaponBuilder() : base(new TypeLineParser(),
            AttributeHelper.Index<OneHandedWeaponAttribute>())
        {
        }
    }
}