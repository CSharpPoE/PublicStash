using System;
using System.Collections.Generic;

namespace PathOfExile.Model.Items.Map
{
    public class Breachstone : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Chayula's Breachstone",
            "Esh's Breachstone",
            "Tul's Breachstone",
            "Uul-Netol's Breachstone",
            "Xoph's Breachstone"
        };

        public string descrText { get; set; }
        public string inventoryId { get; set; }
        public string category { get; set; }
    }
}