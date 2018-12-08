using System.Collections.Generic;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Currencies
{
    public class Currency : Item
    {
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

    [Currency("Albino Rhoa Feather")]
    public class AlbinoRhoaFeather : Currency
    {
    }

    [Currency("Apprentice Cartographer's Seal")]
    public class ApprenticeCartographersSeal : Currency
    {
    }

    [Currency("Apprentice Cartographer's Sextant")]
    public class ApprenticeCartographersSextant : Currency
    {
    }

    [Currency("Armourer's Scrap")]
    public class ArmourersScrap : Currency
    {
    }

    [Currency("Blacksmith's Whetstone")]
    public class BlacksmithsWhetstone : Currency
    {
    }

    [Currency("Blessed Orb")]
    public class BlessedOrb : Currency
    {
    }


    [Currency("Cartographer's Chisel")]
    public class CartographersChisel : Currency
    {
    }

    [Currency("Chaos Orb")]
    public class ChaosOrb : Currency
    {
    }

    [Currency("Chromatic Orb")]
    public class ChromaticOrb : Currency
    {
    }

    [Currency("Divine Orb")]
    public class DivineOrb : Currency
    {
    }

    [Currency("Exalted Orb")]
    public class ExaltedOrb : Currency
    {
    }

    [Currency("Gemcutter's Prism")]
    public class GemcuttersPrism : Currency
    {
    }

    [Currency("Glassblower's Bauble")]
    public class GlassblowersBauble : Currency
    {
    }

    [Currency("Jeweller's Orb")]
    public class JewellersOrb : Currency
    {
    }

    [Currency("Journeyman Cartographer's Seal")]
    public class JourneymanCartographersSeal : Currency
    {
    }

    [Currency("Journeyman Cartographer's Sextant")]
    public class JourneymanCartographersSextant : Currency
    {
    }

    [Currency("Master Cartographer's Seal")]
    public class MasterCartographersSeal : Currency
    {
    }

    [Currency("Master Cartographer's Sextant")]
    public class MasterCartographersSextant : Currency
    {
    }

    [Currency("Mirror of Kalandra")]
    public class MirrorOfKalandra : Currency
    {
    }

    [Currency("Orb of Alchemy")]
    public class OrbOfAlchemy : Currency
    {
    }

    [Currency("Orb of Alteration")]
    public class OrbOfAlteration : Currency
    {
    }

    [Currency("Orb of Annulment")]
    public class OrbOfAnnulment : Currency
    {
    }

    [Currency("Orb of Augmentation")]
    public class OrbOfAugmentation : Currency
    {
    }

    [Currency("Orb of Chance")]
    public class OrbOfChance : Currency
    {
    }

    [Currency("Orb of Fusing")]
    public class OrbOfFusing : Currency
    {
    }

    [Currency("Orb of Regret")]
    public class OrbOfRegret : Currency
    {
    }

    [Currency("Orb of Scouring")]
    public class OrbOfScouring : Currency
    {
    }

    [Currency("Orb of Transmutation")]
    public class OrbOfTransmutation : Currency
    {
    }

    [Currency("Portal Scroll")]
    public class PortalScroll : Currency
    {
    }

    [Currency("Regal Orb")]
    public class RegalOrb : Currency
    {
    }

    [Currency("Scroll of Wisdom")]
    public class ScrollOfWisdom : Currency
    {
    }

    [Currency("Silver Coin")]
    public class SilverCoin : Currency
    {
    }

    [Currency("Unshaping Orb")]
    public class UnshapingOrb : Currency
    {
    }

    [Currency("Vaal Orb")]
    public class VaalOrb : Currency
    {
    }
}
