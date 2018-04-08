using System;
using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class Currency : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Albino Rhoa Feather",
            "Alteration Shard",
            "Ancient Orb",
            "Ancient Shard",
            "Alchemy Shard",
            "Annulment Shard",
            "Apprentice Cartographer's Seal",
            "Apprentice Cartographer's Sextant",
            "Armourer's Scrap",
            "Binding Shard",
            "Blacksmith's Whetstone",
            "Blessed Orb",
            "Cartographer's Chisel",
            "Chaos Orb",
            "Chaos Shard",
            "Chromatic Orb",
            "Divine Orb",
            "Engineer's Orb",
            "Engineer's Shard",
            "Eternal Orb",
            "Exalted Orb",
            "Exalted Shard",
            "Gemcutter's Prism",
            "Glassblower's Bauble",
            "Harbinger's Orb",
            "Harbinger's Shard",
            "Horizon Shard",
            "Jeweller's Orb",
            "Journeyman Cartographer's Seal",
            "Journeyman Cartographer's Sextant",
            "Master Cartographer's Seal",
            "Master Cartographer's Sextant",
            "Mirror Shard",
            "Mirror of Kalandra",
            "Orb of Alchemy",
            "Orb of Alteration",
            "Orb of Annulment",
            "Orb of Augmentation",
            "Orb of Binding",
            "Orb of Chance",
            "Orb of Fusing",
            "Orb of Horizons",
            "Orb of Regret",
            "Orb of Scouring",
            "Orb of Transmutation",
            "Perandus Coin",
            "Portal Scroll",
            "Regal Orb",
            "Regal Shard",
            "Transmutation Shard",
            "Scroll of Wisdom",
            "Scroll Fragment",
            "Silver Coin",
            "Stacked Deck",
            "Unshaping Orb",
            "Vaal Orb",

            "Splinter of Chayula",
            "Splinter of Esh",
            "Splinter of Tul",
            "Splinter of Uul-Netol",
            "Splinter of Xoph",

        };

        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int stackSize { get; set; }
        public bool maxStackSize { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }

        public class Category
        {
            public List<object> currency { get; set; }
        }
    }
}
