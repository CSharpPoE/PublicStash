using System;
using System.Collections.Generic;

namespace PathOfExile.Model.Items.Map
{
    public class Fragment : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Divine Vessel",
            "Eber's Key",
            "Fragment of the Chimera",
            "Fragment of the Hydra",
            "Fragment of the Minotaur",
            "Fragment of the Phoenix",
            "Inya's Key",
            "Mortal Grief",
            "Mortal Hope",
            "Mortal Ignorance",
            "Mortal Rage",
            "Offering to the Goddess",
            "Sacrifice at Dawn",
            "Sacrifice at Dusk",
            "Sacrifice at Midnight",
            "Sacrifice at Noon",
            "Volkuur's Key",
            "Yriel's Key"
        };

        public string descrText { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public string inventoryId { get; set; }
        public string category { get; set; }
    }
}