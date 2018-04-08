using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model
{
    public abstract class Armour : Item
    {
        public class Category
        {
            public IEnumerable<string> armour { get; set; }
        }

        public IEnumerable<Socket> sockets { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }
        public bool elder { get; set; }
        public bool shaper { get; set; }

        [JsonConverter(typeof(SockatableConverter))]
        public IEnumerable<SocketableItem> socketedItems { get; set; }
    }
}