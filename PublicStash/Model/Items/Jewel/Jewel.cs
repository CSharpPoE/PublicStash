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


    #region Disabled

    [Jewel("Prismatic Jewel")]
    public class PrismaticJewel : Jewel
    {
    }

    #endregion
}