using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items.Accessories
{
    public class SocketableAccessory : Accessory
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(SockatableConverter))]
        public IEnumerable<SocketableItem> socketedItems { get; set; }
    }
}
