using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Cards
{
    public abstract class Card : Item
    {
        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("flavourText")]
        public IEnumerable<string> FlavourText { get; set; }

        [JsonProperty("stackSize")]
        public int StackSize { get; set; }

        [JsonProperty("maxStackSize")]
        public bool MaxStackSize { get; set; }

        [JsonProperty("artFilename")]
        public string ArtFilename { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }
    }

    [Card("A Mother's Parting Gift")]
    public class AMothersPartingGift : Card
    {
    }

    [Card("Abandoned Wealth")]
    public class AbandonedWealth : Card
    {
    }

    [Card("Anarchy's Price")]
    public class AnarchysPrice : Card
    {
    }

    [Card("Assassin's Favour")]
    public class AssassinsFavour : Card
    {
    }

    [Card("Atziri's Arsenal")]
    public class AtzirisArsenal : Card
    {
    }

    [Card("Audacity")]
    public class Audacity : Card
    {
    }

    [Card("Beauty Through Death")]
    public class BeautyThroughDeath : Card
    {
    }

    [Card("Birth of the Three")]
    public class BirthoftheThree : Card
    {
    }

    [Card("Blessing of God")]
    public class BlessingofGod : Card
    {
    }

    [Card("Blind Venture")]
    public class BlindVenture : Card
    {
    }

    [Card("Boon of the First Ones")]
    public class BoonoftheFirstOnes : Card
    {
    }

    [Card("Boundless Realms")]
    public class BoundlessRealms : Card
    {
    }

    [Card("Bowyer's Dream")]
    public class BowyersDream : Card
    {
    }

    [Card("Call to the First Ones")]
    public class CalltotheFirstOnes : Card
    {
    }

    [Card("Cartographer's Delight")]
    public class CartographersDelight : Card
    {
    }

    [Card("Chaotic Disposition")]
    public class ChaoticDisposition : Card
    {
    }

    [Card("Coveted Possession")]
    public class CovetedPossession : Card
    {
    }

    [Card("Death")]
    public class Death : Card
    {
    }

    [Card("Destined to Crumble")]
    public class DestinedtoCrumble : Card
    {
    }

    [Card("Dialla's Subjugation")]
    public class DiallasSubjugation : Card
    {
    }

    [Card("Doedre's Madness")]
    public class DoedresMadness : Card
    {
    }

    [Card("Earth Drinker")]
    public class EarthDrinker : Card
    {
    }

    [Card("Emperor of Purity")]
    public class EmperorofPurity : Card
    {
    }

    [Card("Emperor's Luck")]
    public class EmperorsLuck : Card
    {
    }

    [Card("Forbidden Power")]
    public class ForbiddenPower : Card
    {
    }

    [Card("Gemcutter's Promise")]
    public class GemcuttersPromise : Card
    {
    }

    [Card("Gift of the Gemling Queen")]
    public class GiftoftheGemlingQueen : Card
    {
    }

    [Card("Glimmer of Hope")]
    public class GlimmerofHope : Card
    {
    }

    [Card("Grave Knowledge")]
    public class GraveKnowledge : Card
    {
    }

    [Card("Harmony of Souls")]
    public class HarmonyofSouls : Card
    {
    }

    [Card("Her Mask")]
    public class HerMask : Card
    {
    }

    [Card("Heterochromia")]
    public class Heterochromia : Card
    {
    }

    [Card("Hope")]
    public class Hope : Card
    {
    }

    [Card("House of Mirrors")]
    public class HouseofMirrors : Card
    {
    }

    [Card("Hubris")]
    public class Hubris : Card
    {
    }

    [Card("Humility")]
    public class Humility : Card
    {
    }

    [Card("Hunter's Resolve")]
    public class HuntersResolve : Card
    {
    }

    [Card("Hunter's Reward")]
    public class HuntersReward : Card
    {
    }

    [Card("Immortal Resolve")]
    public class ImmortalResolve : Card
    {
    }

    [Card("Jack in the Box")]
    public class JackintheBox : Card
    {
    }

    [Card("Lantador's Lost Love")]
    public class LantadorsLostLove : Card
    {
    }

    [Card("Last Hope")]
    public class LastHope : Card
    {
    }

    [Card("Left to Fate")]
    public class LefttoFate : Card
    {
    }

    [Card("Light and Truth")]
    public class LightandTruth : Card
    {
    }

    [Card("Lingering Remnants")]
    public class LingeringRemnants : Card
    {
    }

    [Card("Lost Worlds")]
    public class LostWorlds : Card
    {
    }

    [Card("Loyalty")]
    public class Loyalty : Card
    {
    }

    [Card("Luck of the Vaal")]
    public class LuckoftheVaal : Card
    {
    }

    [Card("Lucky Connections")]
    public class LuckyConnections : Card
    {
    }

    [Card("Lucky Deck")]
    public class LuckyDeck : Card
    {
    }

    [Card("Lysah's Respite")]
    public class LysahsRespite : Card
    {
    }

    [Card("Mawr Blaidd")]
    public class MawrBlaidd : Card
    {
    }

    [Card("Merciless Armament")]
    public class MercilessArmament : Card
    {
    }

    [Card("Might is Right")]
    public class MightisRight : Card
    {
    }

    [Card("Mitts")]
    public class Mitts : Card
    {
    }

    [Card("No Traces")]
    public class NoTraces : Card
    {
    }

    [Card("Perfection")]
    public class Perfection : Card
    {
    }

    [Card("Pride Before the Fall")]
    public class PrideBeforetheFall : Card
    {
    }

    [Card("Prosperity")]
    public class Prosperity : Card
    {
    }

    [Card("Rain of Chaos")]
    public class RainofChaos : Card
    {
    }

    [Card("Rain Tempter")]
    public class RainTempter : Card
    {
    }

    [Card("Rats")]
    public class Rats : Card
    {
    }

    [Card("Rebirth")]
    public class Rebirth : Card
    {
    }

    [Card("Scholar of the Seas")]
    public class ScholaroftheSeas : Card
    {
    }

    [Card("Shard of Fate")]
    public class ShardofFate : Card
    {
    }

    [Card("Struck by Lightning")]
    public class StruckbyLightning : Card
    {
    }

    [Card("The Admirer")]
    public class TheAdmirer : Card
    {
    }

    [Card("The Aesthete")]
    public class TheAesthete : Card
    {
    }

    [Card("The Arena Champion")]
    public class TheArenaChampion : Card
    {
    }

    [Card("The Army of Blood")]
    public class TheArmyofBlood : Card
    {
    }

    [Card("The Artist")]
    public class TheArtist : Card
    {
    }

    [Card("The Avenger")]
    public class TheAvenger : Card
    {
    }

    [Card("The Battle Born")]
    public class TheBattleBorn : Card
    {
    }

    [Card("The Beast")]
    public class TheBeast : Card
    {
    }

    [Card("The Betrayal")]
    public class TheBetrayal : Card
    {
    }

    [Card("The Blazing Fire")]
    public class TheBlazingFire : Card
    {
    }

    [Card("The Body")]
    public class TheBody : Card
    {
    }

    [Card("The Breach")]
    public class TheBreach : Card
    {
    }

    [Card("The Brittle Emperor")]
    public class TheBrittleEmperor : Card
    {
    }

    [Card("The Cacophony")]
    public class TheCacophony : Card
    {
    }

    [Card("The Calling")]
    public class TheCalling : Card
    {
    }

    [Card("The Carrion Crow")]
    public class TheCarrionCrow : Card
    {
    }

    [Card("The Cartographer")]
    public class TheCartographer : Card
    {
    }

    [Card("The Cataclysm")]
    public class TheCataclysm : Card
    {
    }

    [Card("The Catalyst")]
    public class TheCatalyst : Card
    {
    }

    [Card("The Celestial Justicar")]
    public class TheCelestialJusticar : Card
    {
    }

    [Card("The Celestial Stone")]
    public class TheCelestialStone : Card
    {
    }

    [Card("The Chains that Bind")]
    public class TheChainsthatBind : Card
    {
    }

    [Card("The Coming Storm")]
    public class TheComingStorm : Card
    {
    }

    [Card("The Conduit")]
    public class TheConduit : Card
    {
    }

    [Card("The Cursed King")]
    public class TheCursedKing : Card
    {
    }

    [Card("The Dapper Prodigy")]
    public class TheDapperProdigy : Card
    {
    }

    [Card("The Dark Mage")]
    public class TheDarkMage : Card
    {
    }

    [Card("The Darkest Dream")]
    public class TheDarkestDream : Card
    {
    }

    [Card("The Deceiver")]
    public class TheDeceiver : Card
    {
    }

    [Card("The Demoness")]
    public class TheDemoness : Card
    {
    }

    [Card("The Doctor")]
    public class TheDoctor : Card
    {
    }

    [Card("The Doppelganger")]
    public class TheDoppelganger : Card
    {
    }

    [Card("The Dragon")]
    public class TheDragon : Card
    {
    }

    [Card("The Dragon's Heart")]
    public class TheDragonsHeart : Card
    {
    }

    [Card("The Dreamer")]
    public class TheDreamer : Card
    {
    }

    [Card("The Dreamland")]
    public class TheDreamland : Card
    {
    }

    [Card("The Drunken Aristocrat")]
    public class TheDrunkenAristocrat : Card
    {
    }

    [Card("The Encroaching Darkness")]
    public class TheEncroachingDarkness : Card
    {
    }

    [Card("The Endless Darkness")]
    public class TheEndlessDarkness : Card
    {
    }

    [Card("The Endurance")]
    public class TheEndurance : Card
    {
    }

    [Card("The Enlightened")]
    public class TheEnlightened : Card
    {
    }

    [Card("The Ethereal")]
    public class TheEthereal : Card
    {
    }

    [Card("The Explorer")]
    public class TheExplorer : Card
    {
    }

    [Card("The Eye of the Dragon")]
    public class TheEyeoftheDragon : Card
    {
    }

    [Card("The Fathomless Depths")]
    public class TheFathomlessDepths : Card
    {
    }

    [Card("The Feast")]
    public class TheFeast : Card
    {
    }

    [Card("The Fiend")]
    public class TheFiend : Card
    {
    }

    [Card("The Fletcher")]
    public class TheFletcher : Card
    {
    }

    [Card("The Flora's Gift")]
    public class TheFlorasGift : Card
    {
    }

    [Card("The Formless Sea")]
    public class TheFormlessSea : Card
    {
    }

    [Card("The Forsaken")]
    public class TheForsaken : Card
    {
    }

    [Card("The Fox")]
    public class TheFox : Card
    {
    }

    [Card("The Gambler")]
    public class TheGambler : Card
    {
    }

    [Card("The Garish Power")]
    public class TheGarishPower : Card
    {
    }

    [Card("The Gemcutter")]
    public class TheGemcutter : Card
    {
    }

    [Card("The Gentleman")]
    public class TheGentleman : Card
    {
    }

    [Card("The Gladiator")]
    public class TheGladiator : Card
    {
    }

    [Card("The Hale Heart")]
    public class TheHaleHeart : Card
    {
    }

    [Card("The Harvester")]
    public class TheHarvester : Card
    {
    }

    [Card("The Hermit")]
    public class TheHermit : Card
    {
    }

    [Card("The Hoarder")]
    public class TheHoarder : Card
    {
    }

    [Card("The Hunger")]
    public class TheHunger : Card
    {
    }

    [Card("The Immortal")]
    public class TheImmortal : Card
    {
    }

    [Card("The Incantation")]
    public class TheIncantation : Card
    {
    }

    [Card("The Innocent")]
    public class TheInnocent : Card
    {
    }

    [Card("The Inoculated")]
    public class TheInoculated : Card
    {
    }

    [Card("The Insatiable")]
    public class TheInsatiable : Card
    {
    }

    [Card("The Inventor")]
    public class TheInventor : Card
    {
    }

    [Card("The Iron Bard")]
    public class TheIronBard : Card
    {
    }

    [Card("The Jester")]
    public class TheJester : Card
    {
    }

    [Card("The Jeweller's Boon")]
    public class TheJewellersBoon : Card
    {
    }

    [Card("The King's Blade")]
    public class TheKingsBlade : Card
    {
    }

    [Card("The King's Heart")]
    public class TheKingsHeart : Card
    {
    }

    [Card("The Last One Standing")]
    public class TheLastOneStanding : Card
    {
    }

    [Card("The Lich")]
    public class TheLich : Card
    {
    }

    [Card("The Lion")]
    public class TheLion : Card
    {
    }

    [Card("The Lord in Black")]
    public class TheLordinBlack : Card
    {
    }

    [Card("The Lover")]
    public class TheLover : Card
    {
    }

    [Card("The Lunaris Priestess")]
    public class TheLunarisPriestess : Card
    {
    }

    [Card("The Master")]
    public class TheMaster : Card
    {
    }

    [Card("The Mayor")]
    public class TheMayor : Card
    {
    }

    [Card("The Mercenary")]
    public class TheMercenary : Card
    {
    }

    [Card("The Metalsmith's Gift")]
    public class TheMetalsmithsGift : Card
    {
    }

    [Card("The Oath")]
    public class TheOath : Card
    {
    }

    [Card("The Obscured")]
    public class TheObscured : Card
    {
    }

    [Card("The Offering")]
    public class TheOffering : Card
    {
    }

    [Card("The One With All")]
    public class TheOneWithAll : Card
    {
    }

    [Card("The Opulent")]
    public class TheOpulent : Card
    {
    }

    [Card("The Pack Leader")]
    public class ThePackLeader : Card
    {
    }

    [Card("The Pact")]
    public class ThePact : Card
    {
    }

    [Card("The Penitent")]
    public class ThePenitent : Card
    {
    }

    [Card("The Poet")]
    public class ThePoet : Card
    {
    }

    [Card("The Polymath")]
    public class ThePolymath : Card
    {
    }

    [Card("The Porcupine")]
    public class ThePorcupine : Card
    {
    }

    [Card("The Price of Protection")]
    public class ThePriceofProtection : Card
    {
    }

    [Card("The Professor")]
    public class TheProfessor : Card
    {
    }

    [Card("The Puzzle")]
    public class ThePuzzle : Card
    {
    }

    [Card("The Queen")]
    public class TheQueen : Card
    {
    }

    [Card("The Rabid Rhoa")]
    public class TheRabidRhoa : Card
    {
    }

    [Card("The Realm")]
    public class TheRealm : Card
    {
    }

    [Card("The Risk")]
    public class TheRisk : Card
    {
    }

    [Card("The Rite of Elements")]
    public class TheRiteofElements : Card
    {
    }

    [Card("The Road to Power")]
    public class TheRoadtoPower : Card
    {
    }

    [Card("The Ruthless Ceinture")]
    public class TheRuthlessCeinture : Card
    {
    }

    [Card("The Saint's Treasure")]
    public class TheSaintsTreasure : Card
    {
    }

    [Card("The Samurai's Eye")]
    public class TheSamuraisEye : Card
    {
    }

    [Card("The Scarred Meadow")]
    public class TheScarredMeadow : Card
    {
    }

    [Card("The Scavenger")]
    public class TheScavenger : Card
    {
    }

    [Card("The Scholar")]
    public class TheScholar : Card
    {
    }

    [Card("The Sephirot")]
    public class TheSephirot : Card
    {
    }

    [Card("The Sigil")]
    public class TheSigil : Card
    {
    }

    [Card("The Siren")]
    public class TheSiren : Card
    {
    }

    [Card("The Soul")]
    public class TheSoul : Card
    {
    }

    [Card("The Spark and the Flame")]
    public class TheSparkandtheFlame : Card
    {
    }

    [Card("The Spoiled Prince")]
    public class TheSpoiledPrince : Card
    {
    }

    [Card("The Standoff")]
    public class TheStandoff : Card
    {
    }

    [Card("The Stormcaller")]
    public class TheStormcaller : Card
    {
    }

    [Card("The Summoner")]
    public class TheSummoner : Card
    {
    }

    [Card("The Sun")]
    public class TheSun : Card
    {
    }

    [Card("The Surgeon")]
    public class TheSurgeon : Card
    {
    }

    [Card("The Surveyor")]
    public class TheSurveyor : Card
    {
    }

    [Card("The Survivalist")]
    public class TheSurvivalist : Card
    {
    }

    [Card("The Sword King's Salute")]
    public class TheSwordKingsSalute : Card
    {
    }

    [Card("The Thaumaturgist")]
    public class TheThaumaturgist : Card
    {
    }

    [Card("The Throne")]
    public class TheThrone : Card
    {
    }

    [Card("The Tower")]
    public class TheTower : Card
    {
    }

    [Card("The Traitor")]
    public class TheTraitor : Card
    {
    }

    [Card("The Trial")]
    public class TheTrial : Card
    {
    }

    [Card("The Twilight Moon")]
    public class TheTwilightMoon : Card
    {
    }

    [Card("The Twins")]
    public class TheTwins : Card
    {
    }

    [Card("The Tyrant")]
    public class TheTyrant : Card
    {
    }

    [Card("The Undaunted")]
    public class TheUndaunted : Card
    {
    }

    [Card("The Undisputed")]
    public class TheUndisputed : Card
    {
    }

    [Card("The Union")]
    public class TheUnion : Card
    {
    }

    [Card("The Valkyrie")]
    public class TheValkyrie : Card
    {
    }

    [Card("The Valley of Steel Boxes")]
    public class TheValleyofSteelBoxes : Card
    {
    }

    [Card("The Vast")]
    public class TheVast : Card
    {
    }

    [Card("The Visionary")]
    public class TheVisionary : Card
    {
    }

    [Card("The Void")]
    public class TheVoid : Card
    {
    }

    [Card("The Warden")]
    public class TheWarden : Card
    {
    }

    [Card("The Warlord")]
    public class TheWarlord : Card
    {
    }

    [Card("The Watcher")]
    public class TheWatcher : Card
    {
    }

    [Card("The Web")]
    public class TheWeb : Card
    {
    }

    [Card("The Wilted Rose")]
    public class TheWiltedRose : Card
    {
    }

    [Card("The Wind")]
    public class TheWind : Card
    {
    }

    [Card("The Witch")]
    public class TheWitch : Card
    {
    }

    [Card("The Wolf")]
    public class TheWolf : Card
    {
    }

    [Card("The Wolf's Shadow")]
    public class TheWolfsShadow : Card
    {
    }

    [Card("The Wolven King's Bite")]
    public class TheWolvenKingsBite : Card
    {
    }

    [Card("The Wolverine")]
    public class TheWolverine : Card
    {
    }

    [Card("The World Eater")]
    public class TheWorldEater : Card
    {
    }

    [Card("The Wrath")]
    public class TheWrath : Card
    {
    }

    [Card("The Wretched")]
    public class TheWretched : Card
    {
    }

    [Card("Three Faces in the Dark")]
    public class ThreeFacesintheDark : Card
    {
    }

    [Card("Three Voices")]
    public class ThreeVoices : Card
    {
    }

    [Card("Thunderous Skies")]
    public class ThunderousSkies : Card
    {
    }

    [Card("Time-Lost Relic")]
    public class TimeLostRelic : Card
    {
    }

    [Card("Tranquillity")]
    public class Tranquillity : Card
    {
    }

    [Card("Treasure Hunter")]
    public class TreasureHunter : Card
    {
    }

    [Card("Turn the Other Cheek")]
    public class TurntheOtherCheek : Card
    {
    }

    [Card("Vinia's Token")]
    public class ViniasToken : Card
    {
    }

    [Card("Volatile Power")]
    public class VolatilePower : Card
    {
    }

    [Card("Wealth and Power")]
    public class WealthandPower : Card
    {
    }
}