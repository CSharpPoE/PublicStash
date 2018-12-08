using System;
using System.Collections.Generic;

namespace PathOfExile.Model.Items.Jewel
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

        public bool abyss { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }

    }
}
