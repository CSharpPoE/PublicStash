using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class Stash
    {
        public string accountName { get; set; }
        public string lastCharacterName { get; set; }
        public string id { get; set; }
        public string stash { get; set; }
        public string stashType { get; set; }
        public IEnumerable<Item> items { get; set; }
        public bool @public { get; set; }
    }
}
