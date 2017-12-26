using System;
using System.Collections.Generic;

namespace QuickPOE.Model
{
    internal class Ring : AbstractItem
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            #region RING

            "Breach Ring",
            "Iron Ring",
            "Coral Ring",
            "Paua Ring",
            "Gold Ring",
            "Sapphire Ring",
            "Golden Hoop",
            "Topaz Ring",
            "Jet Ring",
            "Ruby Ring",
            "Two-Stone Ring",
            "Diamond Ring",
            "Moonstone Ring",
            "Prismatic Ring",
            "Amethyst Ring",
            "Unset Ring",
            "Opal Ring",
            "Steel Ring",

            #endregion
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
        public bool elder { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> implicitMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public int frameType { get; set; }
        public Category category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public IEnumerable<SocketableItem> socketedItems { get; set; }
    }
}