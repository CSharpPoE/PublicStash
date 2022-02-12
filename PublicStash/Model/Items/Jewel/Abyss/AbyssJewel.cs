using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items.Jewels.Abyss
{
    public abstract class AbyssJewel : Jewel
    {
        [JsonProperty("abyss")]
        public bool Abyss { get; set; }

        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("requirements")]
        public IEnumerable<Requirement> Requirements { get; set; }
    }

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
}