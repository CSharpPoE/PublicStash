using System;

namespace PublicStashExample.Example.Trade
{
    public enum Currency
    {
        MISSING_TYPE,

        ALBINO_RHOA_FEATHER,
        ALTERATION_SHARD,
        ANCIENT_ORB,
        ANCIENT_SHARD,
        ALCHEMY_SHARD,
        ANNULMENT_SHARD,
        APPRENTICE_CARTOGRAPHERS_SEAL,
        APPRENTICE_CARTOGRAPHERS_SEXTANT,
        ARMOURERS_SCRAP,
        BINDING_SHARD,
        BLACKSMITHS_WHETSTONE,
        BLESSED_ORB,
        CARTOGRAPHERS_CHISEL,
        CHAOS_ORB,
        CHAOS_SHARD,
        CHROMATIC_ORB,
        DIVINE_ORB,
        ENGINEERS_ORB,
        ENGINEERS_SHARD,
        ETERNAL_ORB,
        EXALTED_ORB,
        EXALTED_SHARD,
        GEMCUTTERS_PRISM,
        GLASSBLOWERS_BAUBLE,
        HARBINGERS_ORB,
        HARBINGERS_SHARD,
        HORIZON_SHARD,
        JEWELLERS_ORB,
        JOURNEYMAN_CARTOGRAPHERS_SEAL,
        JOURNEYMAN_CARTOGRAPHERS_SEXTANT,
        MASTER_CARTOGRAPHERS_SEAL,
        MASTER_CARTOGRAPHERS_SEXTANT,
        MIRROR_SHARD,
        MIRROR_OF_KALANDRA,
        ORB_OF_ALCHEMY,
        ORB_OF_ALTERATION,
        ORB_OF_ANNULMENT,
        ORB_OF_AUGMENTATION,
        ORB_OF_BINDING,
        ORB_OF_CHANCE,
        ORB_OF_FUSING,
        ORB_OF_HORIZONS,
        ORB_OF_REGRET,
        ORB_OF_SCOURING,
        ORB_OF_TRANSMUTATION,
        PERANDUS_COIN,
        PORTAL_SCROLL,
        REGAL_ORB,
        REGAL_SHARD,
        TRANSMUTATION_SHARD,
        SCROLL_OF_WISDOM,
        SCROLL_FRAGMENT,
        SILVER_COIN,
        STACKED_DECK,
        UNSHAPING_ORB,
        VAAL_ORB,

        SPLINTER_OF_CHAYULA,
        SPLINTER_OF_ESH,
        SPLINTER_OF_TUL,
        SPLINTER_OF_UUL_NETOL,
        SPLINTER_OF_XOPH,

        MORTAL_SET,
        SHAPER_SET,
    }

    internal static class CurrencyExtension
    {
        public static Currency Parse(this Currency curr, String currency)
        {
            switch (currency)
            {
                case "Albino Rhoa Feather": return Currency.ALBINO_RHOA_FEATHER;
                case "Alteration Shard": return Currency.ALTERATION_SHARD;
                case "Ancient Orb": return Currency.ANCIENT_ORB;
                case "Ancient Shard": return Currency.ANCIENT_SHARD;
                case "Alchemy Shard": return Currency.ALCHEMY_SHARD;
                case "Annulment Shard": return Currency.ANNULMENT_SHARD;
                case "Apprentice Cartographer's Seal": return Currency.APPRENTICE_CARTOGRAPHERS_SEAL;
                case "apprentice-sextant":
                case "Apprentice Cartographer's Sextant": return Currency.APPRENTICE_CARTOGRAPHERS_SEXTANT;
                case "Armourer's Scrap": return Currency.ARMOURERS_SCRAP;
                case "Binding Shard": return Currency.BINDING_SHARD;
                case "Blacksmith's Whetstone": return Currency.BLACKSMITHS_WHETSTONE;
                case "blessed":
                case "Blessed Orb": return Currency.BLESSED_ORB;
                case "chisel":
                case "Cartographer's Chisel": return Currency.CARTOGRAPHERS_CHISEL;
                case "chaos":
                case "Chaos Orb": return Currency.CHAOS_ORB;
                case "Chaos Shard": return Currency.CHAOS_SHARD;
                case "chrom":
                case "Chromatic Orb": return Currency.CHROMATIC_ORB;
                case "divine":
                case "Divine Orb": return Currency.DIVINE_ORB;
                case "Engineer's Orb": return Currency.ENGINEERS_ORB;
                case "Engineer's Shard": return Currency.ENGINEERS_SHARD;
                case "Eternal Orb": return Currency.ETERNAL_ORB;
                case "exa":
                case "exalted":
                case "Exalted Orb": return Currency.EXALTED_ORB;
                case "Exalted Shard": return Currency.EXALTED_SHARD;
                case "gcp":
                case "Gemcutter's Prism": return Currency.GEMCUTTERS_PRISM;
                case "bauble":
                case "Glassblower's Bauble": return Currency.GLASSBLOWERS_BAUBLE;
                case "Harbinger's Orb": return Currency.HARBINGERS_ORB;
                case "Harbinger's Shard": return Currency.HARBINGERS_SHARD;
                case "Horizon Shard": return Currency.HORIZON_SHARD;
                case "jew":
                case "Jeweller's Orb": return Currency.JEWELLERS_ORB;
                case "Journeyman Cartographer's Seal": return Currency.JOURNEYMAN_CARTOGRAPHERS_SEAL;
                case "journeyman-sextant":
                case "Journeyman Cartographer's Sextant": return Currency.JOURNEYMAN_CARTOGRAPHERS_SEXTANT;
                case "Master Cartographer's Seal": return Currency.MASTER_CARTOGRAPHERS_SEAL;
                case "master-sextant":
                case "Master Cartographer's Sextant": return Currency.MASTER_CARTOGRAPHERS_SEXTANT;
                case "Mirror Shard": return Currency.MIRROR_SHARD;
                case "Mirror of Kalandra": return Currency.MIRROR_OF_KALANDRA;
                case "alch":
                case "Orb of Alchemy": return Currency.ORB_OF_ALCHEMY;
                case "alt":
                case "Orb of Alteration": return Currency.ORB_OF_ALTERATION;
                case "orb-of-annulment":
                case "Orb of Annulment": return Currency.ORB_OF_ANNULMENT;
                case "Orb of Augmentation": return Currency.ORB_OF_AUGMENTATION;
                case "Orb of Binding": return Currency.ORB_OF_BINDING;
                case "chance":
                case "Orb of Chance": return Currency.ORB_OF_CHANCE;
                case "fuse":
                case "Orb of Fusing": return Currency.ORB_OF_FUSING;
                case "Orb of Horizons": return Currency.ORB_OF_HORIZONS;
                case "regret":
                case "Orb of Regret": return Currency.ORB_OF_REGRET;
                case "scour":
                case "Orb of Scouring": return Currency.ORB_OF_SCOURING;
                case "Orb of Transmutation": return Currency.ORB_OF_TRANSMUTATION;
                case "Perandus Coin": return Currency.PERANDUS_COIN;
                case "Portal Scroll": return Currency.PORTAL_SCROLL;
                case "regal":
                case "Regal Orb": return Currency.REGAL_ORB;
                case "Regal Shard": return Currency.REGAL_SHARD;
                case "Transmutation Shard": return Currency.TRANSMUTATION_SHARD;
                case "Scroll of Wisdom": return Currency.SCROLL_OF_WISDOM;
                case "Scroll Fragment": return Currency.SCROLL_FRAGMENT;
                case "silver":
                case "Silver Coin": return Currency.SILVER_COIN;
                case "Stacked Deck": return Currency.STACKED_DECK;
                case "Unshaping Orb": return Currency.UNSHAPING_ORB;
                case "vaal":
                case "Vaal Orb": return Currency.VAAL_ORB;

                case "splinter-chayula":
                case "splinter-of-chayula":
                case "Splinter of Chayula": return Currency.SPLINTER_OF_CHAYULA;
                case "Splinter of Esh": return Currency.SPLINTER_OF_ESH;
                case "Splinter of Tul": return Currency.SPLINTER_OF_TUL;
                case "Splinter of Uul-Netol": return Currency.SPLINTER_OF_UUL_NETOL;
                case "Splinter of Xoph": return Currency.SPLINTER_OF_XOPH;

                #region TODO

                // Essence
                case "remnant-of-corruption":

                // Fragments
                case "dusk":
                case "dawn":
                case "noon":
                case "midnight":

                // Set
                case "mortal-set":
                case "shaper-set":

                case "offering":

                #endregion

                default: return Currency.MISSING_TYPE;
            }
        }

        internal static String Value(this Currency curr)
        {
            switch (curr)
            {
                case Currency.ALBINO_RHOA_FEATHER: return "Albino Rhoa Feather";
                case Currency.ALTERATION_SHARD: return "Alteration Shard";
                case Currency.ANCIENT_ORB: return "Ancient Orb";
                case Currency.ANCIENT_SHARD: return "Ancient Shard";
                case Currency.ALCHEMY_SHARD: return "Alchemy Shard";
                case Currency.ANNULMENT_SHARD: return "Annulment Shard";
                case Currency.APPRENTICE_CARTOGRAPHERS_SEAL: return "Apprentice Cartographer's Seal";
                case Currency.APPRENTICE_CARTOGRAPHERS_SEXTANT: return "Apprentice Cartographer's Sextant";
                case Currency.ARMOURERS_SCRAP: return "Armourer's Scrap";
                case Currency.BINDING_SHARD: return "Binding Shard";
                case Currency.BLACKSMITHS_WHETSTONE: return "Blacksmith's Whetstone";
                case Currency.BLESSED_ORB: return "Blessed Orb";
                case Currency.CARTOGRAPHERS_CHISEL: return "Cartographer's Chisel";
                case Currency.CHAOS_ORB: return "Chaos Orb";
                case Currency.CHAOS_SHARD: return "Chaos Shard";
                case Currency.CHROMATIC_ORB: return "Chromatic Orb";
                case Currency.DIVINE_ORB: return "Divine Orb";
                case Currency.ENGINEERS_ORB: return "Engineer's Orb";
                case Currency.ENGINEERS_SHARD: return "Engineer's Shard";
                case Currency.ETERNAL_ORB: return "Eternal Orb";
                case Currency.EXALTED_ORB: return "Exalted Orb";
                case Currency.EXALTED_SHARD: return "Exalted Shard";
                case Currency.GEMCUTTERS_PRISM: return "Gemcutter's Prism";
                case Currency.GLASSBLOWERS_BAUBLE: return "Glassblower's Bauble";
                case Currency.HARBINGERS_ORB: return "Harbinger's Orb";
                case Currency.HARBINGERS_SHARD: return "Harbinger's Shard";
                case Currency.HORIZON_SHARD: return "Horizon Shard";
                case Currency.JEWELLERS_ORB: return "Jeweller's Orb";
                case Currency.JOURNEYMAN_CARTOGRAPHERS_SEAL: return "Journeyman Cartographer's Seal";
                case Currency.JOURNEYMAN_CARTOGRAPHERS_SEXTANT: return "Journeyman Cartographer's Sextant";
                case Currency.MASTER_CARTOGRAPHERS_SEAL: return "Master Cartographer's Seal";
                case Currency.MASTER_CARTOGRAPHERS_SEXTANT: return "Master Cartographer's Sextant";
                case Currency.MIRROR_SHARD: return "Mirror Shard";
                case Currency.MIRROR_OF_KALANDRA: return "Mirror of Kalandra";
                case Currency.ORB_OF_ALCHEMY: return "Orb of Alchemy";
                case Currency.ORB_OF_ALTERATION: return "Orb of Alteration";
                case Currency.ORB_OF_ANNULMENT: return "Orb of Annulment";
                case Currency.ORB_OF_AUGMENTATION: return "Orb of Augmentation";
                case Currency.ORB_OF_BINDING: return "Orb of Binding";
                case Currency.ORB_OF_CHANCE: return "Orb of Chance";
                case Currency.ORB_OF_FUSING: return "Orb of Fusing";
                case Currency.ORB_OF_HORIZONS: return "Orb of Horizons";
                case Currency.ORB_OF_REGRET: return "Orb of Regret";
                case Currency.ORB_OF_SCOURING: return "Orb of Scouring";
                case Currency.ORB_OF_TRANSMUTATION: return "Orb of Transmutation";
                case Currency.PERANDUS_COIN: return "Perandus Coin";
                case Currency.PORTAL_SCROLL: return "Portal Scroll";
                case Currency.REGAL_ORB: return "Regal Orb";
                case Currency.REGAL_SHARD: return "Regal Shard";
                case Currency.TRANSMUTATION_SHARD: return "Transmutation Shard";
                case Currency.SCROLL_OF_WISDOM: return "Scroll of Wisdom";
                case Currency.SCROLL_FRAGMENT: return "Scroll Fragment";
                case Currency.SILVER_COIN: return "Silver Coin";
                case Currency.STACKED_DECK: return "Stacked Deck";
                case Currency.UNSHAPING_ORB: return "Unshaping Orb";
                case Currency.VAAL_ORB: return "Vaal Orb";

                case Currency.SPLINTER_OF_CHAYULA: return "Splinter of Chayula";
                case Currency.SPLINTER_OF_ESH: return "Splinter of Esh";
                case Currency.SPLINTER_OF_TUL: return "Splinter of Tul";
                case Currency.SPLINTER_OF_UUL_NETOL: return "Splinter of Uul-Netol";
                case Currency.SPLINTER_OF_XOPH: return "Splinter of Xoph";

                default: return "Missing Type";
            }
        }
    }
}