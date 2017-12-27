using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    internal class Essence : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Essence of Anger",
            "Essence of Anguish",
            "Essence of Contempt",
            "Essence of Delirium",
            "Essence of Doubt",
            "Essence of Dread",
            "Essence of Envy",
            "Essence of Fear",
            "Essence of Greed",
            "Essence of Hatred",
            "Essence of Horror",
            "Essence of Hysteria",
            "Essence of Insanity",
            "Essence of Loathing",
            "Essence of Misery",
            "Essence of Rage",
            "Essence of Scorn",
            "Essence of Sorrow",
            "Essence of Spite",
            "Essence of Suffering",
            "Essence of Torment",
            "Essence of Woe",
            "Essence of Wrath",
            "Essence of Zeal",
            "Remnant of Corruption",
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
