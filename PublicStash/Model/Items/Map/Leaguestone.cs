using System;
using System.Collections.Generic;

namespace PathOfExile.Model.Items.Map
{
    public class Leaguestone : Item
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

        public bool corrupted { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> implicitMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }

        public class Category
        {
            public List<object> leaguestones { get; set; }
        }
    }
}