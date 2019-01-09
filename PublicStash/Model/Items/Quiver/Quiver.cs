using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Quivers
{
    public abstract class Quiver : Item
    {
        public class QuiverCategory
        {
            [JsonProperty("armour")]
            public IEnumerable<string> Armour { get; set; }
        }

        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("requirements")]
        public IEnumerable<Requirement> Requirements { get; set; }

        [JsonProperty("implicitMods")]
        public IEnumerable<string> ImplicitMods { get; set; }

        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("flavourText")]
        public IEnumerable<string> FlavourText { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }

        [JsonProperty("category")]
        public QuiverCategory Category { get; set; }

        [JsonProperty("elder")]
        public bool Elder { get; set; }

        [JsonProperty("shaper")]
        public bool Shaper { get; set; }
    }

    #region Regular

    [Quiver("Two-Point Arrow Quiver")]
    public class TwoPointArrowQuiver : Quiver
    {
    }

    [Quiver("Serrated Arrow Quiver")]
    public class SerratedArrowQuiver : Quiver
    {
    }

    [Quiver("Sharktooth Arrow Quiver")]
    public class SharktoothArrowQuiver : Quiver
    {
    }

    [Quiver("Blunt Arrow Quiver")]
    public class BluntArrowQuiver : Quiver
    {
    }

    [Quiver("Fire Arrow Quiver")]
    public class FireArrowQuiver : Quiver
    {
    }

    [Quiver("Broadhead Arrow Quiver")]
    public class BroadheadArrowQuiver : Quiver
    {
    }

    [Quiver("Penetrating Arrow Quiver")]
    public class PenetratingArrowQuiver : Quiver
    {
    }

    [Quiver("Spike-Point Arrow Quiver")]
    public class SpikePointArrowQuiver : Quiver
    {
    }

    #endregion

    #region Disabled

    [Quiver("Rugged Quiver")]
    public class RuggedQuiver : Quiver
    {
    }

    [Quiver("Cured Quiver")]
    public class CuredQuiver : Quiver
    {
    }

    [Quiver("Conductive Quiver")]
    public class ConductiveQuiver : Quiver
    {
    }

    [Quiver("Heavy Quiver")]
    public class HeavyQuiver : Quiver
    {
    }

    [Quiver("Light Quiver")]
    public class LightQuiver : Quiver
    {
    }

    #endregion
}