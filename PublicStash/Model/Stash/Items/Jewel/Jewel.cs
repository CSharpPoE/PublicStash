using System;
using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class Jewel : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Cobalt Jewel",
            "Crimson Jewel",
            "Viridian Jewel",
            "Prismatic Jewel"
        };

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public bool identified { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int frameType { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public string category { get; set; }

    }
}
