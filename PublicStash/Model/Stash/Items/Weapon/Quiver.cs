using System;
using System.Collections.Generic;

namespace PoEPublicStash.Model
{
    public class Quiver : Weapon
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Blunt Arrow Quiver",
            "Broadhead Arrow Quiver",
            "Conductive Quiver",
            "Cured Quiver",
            "Fire Arrow Quiver",
            "Heavy Quiver",
            "Light Quiver",
            "Penetrating Arrow Quiver",
            "Rugged Quiver",
            "Serrated Arrow Quiver",
            "Sharktooth Arrow Quiver",
            "Spike-Point Arrow Quiver",
            "Two-Point Arrow Quiver"
        };
    }
}
