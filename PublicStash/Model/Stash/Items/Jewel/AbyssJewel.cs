using System;
using System.Collections.Generic;

namespace PoEPublicStash.Model
{
    public class AbyssJewel : SocketableItem
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Ghastly Eye Jewel",
            "Hypnotic Eye Jewel",
            "Murderous Eye Jewel",
            "Searching Eye Jewel"
        };

        public class Category
        {
            public IEnumerable<string> jewels { get; set; }
        }

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public bool abyss { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int frameType { get; set; }
        public Category category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }

    }
}
