using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    public class Breachstone : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Chayula's Breachstone",
            "Esh's Breachstone",
            "Tul's Breachstone",
            "Uul-Netol's Breachstone",
            "Xoph's Breachstone"
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
        public int frameType { get; set; }
        public string category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }
}