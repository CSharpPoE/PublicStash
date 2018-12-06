using System;
using System.Collections.Generic;

namespace PathOfExile.Model.Items.Currencies
{
    public class Currency : Item
    {
        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public string descrText { get; set; }
        public int stackSize { get; set; }
        public bool maxStackSize { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }

        public class Category
        {
            public List<object> currency { get; set; }
        }
    }
}
