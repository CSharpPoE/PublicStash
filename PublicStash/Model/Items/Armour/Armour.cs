using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items.Armours
{
    public abstract class Armour : Item, Socketable
    {
        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("requirements")]
        public IEnumerable<Requirement> Requirements { get; set; }

        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("flavourText")]
        public IEnumerable<string> FlavourText { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }

        [JsonProperty("elder")]
        public bool Elder { get; set; }

        [JsonProperty("shaper")]
        public bool Shaper { get; set; }

        public IEnumerable<Socket> Sockets { get; set; }
        public IEnumerable<Item> SocketedItems { get; set; }
    }
}