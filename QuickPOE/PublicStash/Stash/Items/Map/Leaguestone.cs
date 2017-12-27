using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    internal class Leaguestone : AbstractItem
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Ambush Leaguestone",
            "Anarchy Leaguestone",
            "Beyond Leaguestone",
            "Bloodlines Leaguestone",
            "Breach Leaguestone",
            "Domination Leaguestone",
            "Essence Leaguestone",
            "Invasion Leaguestone",
            "Nemesis Leaguestone",
            "Onslaught Leaguestone",
            "Perandus Leaguestone",
            "Prophecy Leaguestone",
            "Rampage Leaguestone",
            "Talisman Leaguestone",
            "Tempest Leaguestone",
            "Torment Leaguestone",
            "Warbands Leaguestone",
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
        public bool corrupted { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> implicitMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int frameType { get; set; }
        public string category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }
}