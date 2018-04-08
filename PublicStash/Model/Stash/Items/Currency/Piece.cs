using System.Collections.Generic;

namespace PathOfExile.Model
{
    public class Piece : Item
    {
        public class Category
        {
            public List<string> currency { get; set; }
        }

        public string descrText { get; set; }
        public Category category { get; set; }
        public string inventoryId { get; set; }
    }
}