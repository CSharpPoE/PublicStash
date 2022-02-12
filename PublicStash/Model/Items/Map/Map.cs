using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Maps
{
    public abstract class Map : Item
    {
        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("flavourText")]
        public IEnumerable<string> FlavourText { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }
    }

    [Map("Acid Caverns Map")]
    public class AcidCaverns : Map
    {
    }

    [Map("Alleyways Map")]
    public class Alleyways : Map
    {
    }

    [Map("Ancient City Map")]
    public class AncientCity : Map
    {
    }

    [Map("Arachnid Nest Map")]
    public class ArachnidNest : Map
    {
    }

    [Map("Arcade Map")]
    public class Arcade : Map
    {
    }

    [Map("Arid Lake Map")]
    public class AridLake : Map
    {
    }

    [Map("Armoury Map")]
    public class Armoury : Map
    {
    }

    [Map("Arsenal Map")]
    public class Arsenal : Map
    {
    }

    [Map("Ashen Wood Map")]
    public class AshenWood : Map
    {
    }

    [Map("Atoll Map")]
    public class Atoll : Map
    {
    }

    [Map("Basilica Map")]
    public class Basilica : Map
    {
    }

    [Map("Bazaar Map")]
    public class Bazaar : Map
    {
    }

    [Map("Beach Map")]
    public class Beach : Map
    {
    }

    [Map("Belfry Map")]
    public class Belfry : Map
    {
    }

    [Map("Bog Map")]
    public class Bog : Map
    {
    }

    [Map("Bone Crypt Map")]
    public class BoneCrypt : Map
    {
    }

    [Map("Bramble Valley Map")]
    public class BrambleValley : Map
    {
    }

    [Map("Burial Chambers Map")]
    public class BurialChambers : Map
    {
    }

    [Map("Cage Map")]
    public class Cage : Map
    {
    }

    [Map("Caldera Map")]
    public class Caldera : Map
    {
    }

    [Map("Canyon Map")]
    public class Canyon : Map
    {
    }

    [Map("Carcass Map")]
    public class Carcass : Map
    {
    }

    [Map("Cells Map")]
    public class Cells : Map
    {
    }

    [Map("Cemetery Map")]
    public class Cemetery : Map
    {
    }

    [Map("Channel Map")]
    public class Channel : Map
    {
    }

    [Map("City Square Map")]
    public class CitySquare : Map
    {
    }

    [Map("Cold River Map")]
    public class ColdRiver : Map
    {
    }

    [Map("Colosseum Map")]
    public class Colosseum : Map
    {
    }

    [Map("Conservatory Map")]
    public class Conservatory : Map
    {
    }

    [Map("Coral Ruins Map")]
    public class CoralRuins : Map
    {
    }

    [Map("Courtyard Map")]
    public class Courtyard : Map
    {
    }

    [Map("Coves Map")]
    public class Coves : Map
    {
    }

    [Map("Crimson Temple Map")]
    public class CrimsonTemple : Map
    {
    }

    [Map("Crimson Township Map")]
    public class CrimsonTownship : Map
    {
    }

    [Map("Cursed Crypt Map")]
    public class CursedCrypt : Map
    {
    }

    [Map("Dark Forest Map")]
    public class DarkForest : Map
    {
    }

    [Map("Defiled Cathedral Map")]
    public class DefiledCathedral : Map
    {
    }

    [Map("Desert Spring Map")]
    public class DesertSpring : Map
    {
    }

    [Map("Dig Map")]
    public class Dig : Map
    {
    }

    [Map("Dry Sea Map")]
    public class DrySea : Map
    {
    }

    [Map("Dunes Map")]
    public class Dunes : Map
    {
    }

    [Map("Dungeon Map")]
    public class Dungeon : Map
    {
    }

    [Map("Estuary Map")]
    public class Estuary : Map
    {
    }

    [Map("Fields Map")]
    public class Fields : Map
    {
    }

    [Map("Flooded Mine Map")]
    public class FloodedMine : Map
    {
    }

    [Map("Forbidden Woods Map")]
    public class ForbiddenWoods : Map
    {
    }

    [Map("Forge of the Phoenix Map")]
    public class ForgeOfThePhoenix : Map
    {
    }

    [Map("Forking River Map")]
    public class ForkingRiver : Map
    {
    }

    [Map("Frozen Cabins Map")]
    public class FrozenCabins : Map
    {
    }

    [Map("Gardens Map")]
    public class Gardens : Map
    {
    }

    [Map("Ghetto Map")]
    public class Ghetto : Map
    {
    }

    [Map("Glacier Map")]
    public class Glacier : Map
    {
    }

    [Map("Grave Trough Map")]
    public class GraveTrough : Map
    {
    }

    [Map("Graveyard Map")]
    public class Graveyard : Map
    {
    }

    [Map("Grotto Map")]
    public class Grotto : Map
    {
    }

    [Map("Harbinger Map")]
    public class Harbinger : Map
    {
    }

    [Map("Haunted Mansion Map")]
    public class HauntedMansion : Map
    {
    }

    [Map("Iceberg Map")]
    public class Iceberg : Map
    {
    }

    [Map("Infested Valley Map")]
    public class InfestedValley : Map
    {
    }

    [Map("Ivory Temple Map")]
    public class IvoryTemple : Map
    {
    }

    [Map("Jungle Valley Map")]
    public class JungleValley : Map
    {
    }

    [Map("Laboratory Map")]
    public class Laboratory : Map
    {
    }

    [Map("Lair Map")]
    public class Lair : Map
    {
    }

    [Map("Lair of the Hydra Map")]
    public class LairOfTheHydra : Map
    {
    }

    [Map("Lava Chamber Map")]
    public class LavaChamber : Map
    {
    }

    [Map("Lookout Map")]
    public class Lookout : Map
    {
    }

    [Map("Malformation Map")]
    public class Malformation : Map
    {
    }

    [Map("Marshes Map")]
    public class Marshes : Map
    {
    }

    [Map("Mausoleum Map")]
    public class Mausoleum : Map
    {
    }

    [Map("Maze Map")]
    public class Maze : Map
    {
    }

    [Map("Maze of the Minotaur Map")]
    public class MazeOfTheMinotaur : Map
    {
    }

    [Map("Mesa Map")]
    public class Mesa : Map
    {
    }

    [Map("Mineral Pools Map")]
    public class MineralPools : Map
    {
    }

    [Map("Moon Temple Map")]
    public class MoonTemple : Map
    {
    }

    [Map("Museum Map")]
    public class Museum : Map
    {
    }

    [Map("Necropolis Map")]
    public class Necropolis : Map
    {
    }

    [Map("Orchard Map")]
    public class Orchard : Map
    {
    }

    [Map("Overgrown Ruin Map")]
    public class OvergrownRuin : Map
    {
    }

    [Map("Overgrown Shrine Map")]
    public class OvergrownShrine : Map
    {
    }

    [Map("Palace Map")]
    public class Palace : Map
    {
    }

    [Map("Park Map")]
    public class Park : Map
    {
    }

    [Map("Peninsula Map")]
    public class Peninsula : Map
    {
    }

    [Map("Phantasmagoria Map")]
    public class Phantasmagoria : Map
    {
    }

    [Map("Pier Map")]
    public class Pier : Map
    {
    }

    [Map("Pit of the Chimera Map")]
    public class PitOfTheChimera : Map
    {
    }

    [Map("Plateau Map")]
    public class Plateau : Map
    {
    }

    [Map("Plaza Map")]
    public class Plaza : Map
    {
    }

    [Map("Port Map")]
    public class Port : Map
    {
    }

    [Map("Precinct Map")]
    public class Precinct : Map
    {
    }

    [Map("Primordial Pool Map")]
    public class PrimordialPool : Map
    {
    }

    [Map("Promenade Map")]
    public class Promenade : Map
    {
    }

    [Map("Shipyard Map")]
    public class Shipyard : Map
    {
    }

    [Map("Shore Map")]
    public class Shore : Map
    {
    }

    [Map("Shrine Map")]
    public class Shrine : Map
    {
    }

    [Map("Silo Map")]
    public class Silo : Map
    {
    }

    [Map("Spider Forest Map")]
    public class SpiderForest : Map
    {
    }

    [Map("Stagnation Map")]
    public class Stagnation : Map
    {
    }

    [Map("Strand Map")]
    public class Strand : Map
    {
    }

    [Map("Summit Map")]
    public class Summit : Map
    {
    }

    [Map("Synthesised Map")]
    public class Synthesised : Map
    {
    }

    [Map("Temple Map")]
    public class Temple : Map
    {
    }

    [Map("Thicket Map")]
    public class Thicket : Map
    {
    }

    [Map("Tower Map")]
    public class Tower : Map
    {
    }

    [Map("Toxic Sewer Map")]
    public class ToxicSewer : Map
    {
    }

    [Map("Relic Chambers Map")]
    public class RelicChambers : Map
    {
    }

    [Map("Underground River Map")]
    public class UndergroundRiver : Map
    {
    }

    [Map("Underground Sea Map")]
    public class UndergroundSea : Map
    {
    }

    [Map("Vaal Pyramid Map")]
    public class VaalPyramid : Map
    {
    }

    [Map("Vaal Temple Map")]
    public class VaalTemple : Map
    {
    }

    [Map("Vault Map")]
    public class Vault : Map
    {
    }

    [Map("Volcano Map")]
    public class Volcano : Map
    {
    }

    [Map("Waste Pool Map")]
    public class WastePool : Map
    {
    }

    [Map("Wasteland Map")]
    public class Wasteland : Map
    {
    }

    [Map("Wharf Map")]
    public class Wharf : Map
    {
    }
}