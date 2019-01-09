using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items.Maps
{
    public abstract class Map
    {
        [JsonProperty("properties")]
        public IEnumerable<Item.Property> Properties { get; set; }

        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("flavourText")]
        public IEnumerable<string> FlavourText { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }

        [JsonProperty("category")]
        public MapCategory Category { get; set; }

        public class MapCategory
        {
            [JsonProperty("maps")]
            public List<object> Maps { get; set; }
        }
    }


}