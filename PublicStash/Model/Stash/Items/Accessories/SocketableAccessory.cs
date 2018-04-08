using System.Collections.Generic;
using Newtonsoft.Json;
using static Newtonsoft.Json.NullValueHandling;

namespace PathOfExile.Model
{
    public class SocketableAccessory : Accessory
    {
        [JsonProperty(NullValueHandling = Ignore), JsonConverter(typeof(SockatableConverter))]
        public IEnumerable<SocketableItem> socketedItems { get; set; }
    }
}
