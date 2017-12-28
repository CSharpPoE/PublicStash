using System;
using System.Collections.Generic;

namespace PoEPublicStash.Model
{
    public class Blessing : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Blessing of Chayula",
            "Blessing of Esh",
            "Blessing of Tul",
            "Blessing of Uul-Netol",
            "Blessing of Xoph",
        };

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public bool identified { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int frameType { get; set; }
        public int stackSize { get; set; }
        public int maxStackSize { get; set; }
        public string category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }

    }
}
