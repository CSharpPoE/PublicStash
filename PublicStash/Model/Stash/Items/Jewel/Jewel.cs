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

        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }

        public class Category
        {
            public List<object> jewels { get; set; }
        }


    }
}
