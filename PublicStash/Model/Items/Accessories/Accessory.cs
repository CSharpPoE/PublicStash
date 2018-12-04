using System.Collections.Generic;

namespace PathOfExile.Model.Items.Accessories
{
    public class Accessory : Item
    {
        public class Category
        {
            public IEnumerable<string> accessories { get; set; }
        }

        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> implicitMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }
        public bool elder { get; set; }
        public bool shaper { get; set; }
    }
}