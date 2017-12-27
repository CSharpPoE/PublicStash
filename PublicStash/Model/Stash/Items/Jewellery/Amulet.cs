using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    internal class Amulet : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Paua Amulet",
            "Jet Amulet",
            "Coral Amulet",
            "Jade Amulet",
            "Amber Amulet",
            "Lapis Amulet",
            "Gold Amulet",
            "Agate Amulet",
            "Turquoise Amulet",
            "Citrine Amulet",
            "Onyx Amulet",
            "Marble Amulet",
            "Ruby Amulet",
            "Blue Pearl Amulet"
        };


        public class Category
        {
            public IEnumerable<string> accessories { get; set; }
        }

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
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> implicitMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public int frameType { get; set; }
        public Category category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }
}