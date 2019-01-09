using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Jewels
{
    public abstract class Jewel : Item
    {
        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }

        [JsonProperty("category")]
        public JewelCategory Category { get; set; }

        public class JewelCategory
        {
            [JsonProperty("jewels")]
            public List<object> Jewels { get; set; }
        }
    }

    public abstract class AbyssJewel : Jewel
    {
        [JsonProperty("abyss")]
        public bool Abyss { get; set; }

        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("requirements")]
        public IEnumerable<Requirement> Requirements { get; set; }
    }

    #region Regular

    [Jewel("Cobalt Jewel")]
    public class CobaltJewel : Jewel
    {
    }

    [Jewel("Crimson Jewel")]
    public class CrimsonJewel : Jewel
    {
    }

    [Jewel("Viridian Jewel")]
    public class ViridianJewel : Jewel
    {
    }

    #endregion


    #region Abyss

    [AbyssJewel("Ghastly Eye Jewel")]
    public class GhastlyEyeJewel : AbyssJewel
    {
    }

    [AbyssJewel("Hypnotic Eye Jewel")]
    public class HypnoticEyeJewel : AbyssJewel
    {
    }

    [AbyssJewel("Murderous Eye Jewel")]
    public class MurderousEyeJewel : AbyssJewel
    {
    }

    [AbyssJewel("Searching Eye Jewel")]
    public class SearchingEyeJewel : AbyssJewel
    {
    }

    #endregion

    #region Disabled

    [Jewel("Prismatic Jewel")]
    public class PrismaticJewel : Jewel
    {
    }

    #endregion
}