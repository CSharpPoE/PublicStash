using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    internal class UnspecifiedItem : AbstractItem
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }

        public IEnumerable<Socket> sockets { get; set; }
        public String name { get; set; }
        public String typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        public bool lockedToCharacter { get; set; }

        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<String> explicitMods { get; set; }
        public IEnumerable<String> implicitMods { get; set; }
        public IEnumerable<String> enchantMods { get; set; }
        public IEnumerable<String> craftedMods { get; set; }
        public IEnumerable<String> flavourText { get; set; }
        public int frameType { get; set; }

        public IEnumerable<SocketableItem> socketedItems { get; set; }
        public IEnumerable<Property> additionalProperties { get; set; }

        public bool duplicated { get; set; }
        public int maxStackSize { get; set; }
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