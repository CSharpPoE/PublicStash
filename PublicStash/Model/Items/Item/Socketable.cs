using System.Collections.Generic;
using Newtonsoft.Json;
using PathOfExile.Model.Internal;

namespace PathOfExile.Model.Items
{
    internal interface Socketable
    {
        [JsonProperty("sockets")]
        IEnumerable<Item.Socket> Sockets { get; set; }

        [JsonProperty("socketedItems")]
        [JsonConverter(typeof(SocketedItemConverter))]
        IEnumerable<Item> SocketedItems { get; set; }
    }
}
