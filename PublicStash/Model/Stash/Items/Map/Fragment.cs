using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    internal class Fragment : Item
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

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public string descrText { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public int frameType { get; set; }
        public string category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }
}