using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model
{
    public class PublicStash
    {
        [JsonProperty("next_change_id")]
        public string NextChangeId { get; set; }

        [JsonProperty("stashes")]
        public IEnumerable<PublicStashChange> Stashes { get; set; }
    }
}
