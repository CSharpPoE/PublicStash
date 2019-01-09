using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items.Weapons
{
    public abstract class Weapon : Item, Socketable
    {
        public class WeaponCategory
        {
            [JsonProperty("weapons")]
            public IEnumerable<string> Weapons { get; set; }
        }

        public IEnumerable<Socket> Sockets { get; set; }

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

        [JsonProperty("category")]
        public WeaponCategory Category { get; set; }

        [JsonProperty("elder")]
        public bool Elder { get; set; }

        [JsonProperty("shaper")]
        public bool Shaper { get; set; }

        public IEnumerable<Item> SocketedItems { get; set; }
    }
}