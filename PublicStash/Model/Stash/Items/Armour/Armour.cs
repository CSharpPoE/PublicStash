using System.Collections.Generic;

namespace PublicStash.Model
{
    public abstract class Armour : Item
    {
        public class Category
        {
            public IEnumerable<string> armour { get; set; }
        }

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public IEnumerable<Socket> sockets { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public int frameType { get; set; }
        public Category category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public IEnumerable<SocketableItem> socketedItems { get; set; }
    }
}