using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using static Newtonsoft.Json.NullValueHandling;

namespace PathOfExile.Model.Items
{
    public class UnspecifiedItem : Item
    {
        public string inventoryId { get; set; }

        public IEnumerable<Socket> sockets { get; set; }
        public bool corrupted { get; set; }
        public bool lockedToCharacter { get; set; }

        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<String> explicitMods { get; set; }
        public IEnumerable<String> implicitMods { get; set; }
        public IEnumerable<String> enchantMods { get; set; }
        public IEnumerable<String> craftedMods { get; set; }
        public IEnumerable<String> flavourText { get; set; }
        
        [JsonProperty(NullValueHandling = Ignore)]
        [JsonConverter(typeof(SockatableConverter))]
        public IEnumerable<SocketableItem> socketedItems { get; set; }

        public IEnumerable<Property> additionalProperties { get; set; }

        public bool duplicated { get; set; }
        public bool maxStackSize { get; set; }
        public IEnumerable<Requirement> nextLevelRequirements { get; set; }
        public int stackSize { get; set; }
        public int talismanTier { get; set; }
        public IEnumerable<String> utilityMods { get; set; }
        public bool support { get; set; }
        public IEnumerable<String> cosmeticMods { get; set; }
        public String prophecyDiffText { get; set; }
        public String prophecyText { get; set; }

        public bool isRelic { get; set; }
    }
}