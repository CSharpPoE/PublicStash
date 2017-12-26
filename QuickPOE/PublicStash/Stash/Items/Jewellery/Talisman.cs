using System;
using System.Collections.Generic;

namespace QuickPOE.Model
{
    internal class Talisman : AbstractItem
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            #region TALISMAN

            "Mandible Talisman",
            "Hexclaw Talisman",
            "Primal Skull Talisman",
            "Wereclaw Talisman",
            "Splitnewt Talisman",
            "Clutching Talisman",
            "Avian Twins Talisman",
            "Fangjaw Talisman",
            "Horned Talisman",
            "Spinefuse Talisman",
            "Three Rat Talisman",
            "Monkey Twins Talisman",
            "Longtooth Talisman",
            "Rotfeather Talisman",
            "Monkey Paw Talisman",
            "Three Hands Talisman",
            "Black Maw Talisman",
            "Bonespire Talisman",
            "Ashscale Talisman",
            "Lone Antler Talisman",
            "Deep One Talisman",
            "Breakrib Talisman",
            "Deadhand Talisman",
            "Undying Flesh Talisman",
            "Rot Head Talisman",
            "Writhing Talisman",
            "Chrysalis Talisman",

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
