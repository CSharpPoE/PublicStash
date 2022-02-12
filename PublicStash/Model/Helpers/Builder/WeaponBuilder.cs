using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Weapons;

namespace PathOfExile.Model.Internal
{
    internal class WeaponBuilder : TBuilder<Weapon>
    {
        public WeaponBuilder() : base(new BaseTypeParser(), AttributeHelper.Index<WeaponAttribute>())
        {
        }
    }
}