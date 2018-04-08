using System;
using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class Flask : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Amethyst Flask",
            "Aquamarine Flask",
            "Basalt Flask",
            "Bismuth Flask",
            "Colossal Hybrid Flask",
            "Colossal Life Flask",
            "Colossal Mana Flask",
            "Diamond Flask",
            "Divine Life Flask",
            "Divine Mana Flask",
            "Eternal Life Flask",
            "Eternal Mana Flask",
            "Giant Life Flask",
            "Giant Mana Flask",
            "Grand Life Flask",
            "Grand Mana Flask",
            "Granite Flask",
            "Greater Life Flask",
            "Greater Mana Flask",
            "Hallowed Hybrid Flask",
            "Hallowed Life Flask",
            "Hallowed Mana Flask",
            "Jade Flask",
            "Large Hybrid Flask",
            "Large Life Flask",
            "Large Mana Flask",
            "Medium Hybrid Flask",
            "Medium Life Flask",
            "Medium Mana Flask",
            "Quartz Flask",
            "Quicksilver Flask",
            "Ruby Flask",
            "Sacred Hybrid Flask",
            "Sacred Life Flask",
            "Sacred Mana Flask",
            "Sanctified Life Flask",
            "Sanctified Mana Flask",
            "Sapphire Flask",
            "Silver Flask",
            "Small Hybrid Flask",
            "Small Life Flask",
            "Small Mana Flask",
            "Stibnite Flask",
            "Sulphur Flask",
            "Topaz Flask"
        };

        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> utilityMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public Category category { get; set; }
        public string inventoryId { get; set; }

        public class Category
        {
            public List<object> flasks { get; set; }
        }
    }
}