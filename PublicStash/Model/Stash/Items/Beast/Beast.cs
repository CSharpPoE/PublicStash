using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class Beast : Item
    {
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public Category category { get; set; }
        public string inventoryId { get; set; }

        public class Category
        {
            public IEnumerable<object> monsters { get; set; }
        }
    }
}
