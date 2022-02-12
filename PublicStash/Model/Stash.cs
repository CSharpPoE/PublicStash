using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Items;

namespace PathOfExile.Model
{
    public class PublicStashChange
    {
        [JsonProperty("accountName")]
        public string accountName { get; set; }

        [JsonProperty("lastCharacterName")]
        public string lastCharacterName { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("stash")]
        public string Stash { get; set; }

        [JsonProperty("stashType")]
        public string StashType { get; set; }

        [JsonProperty("items")]
        public IEnumerable<Item> Items { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }
    }
}
