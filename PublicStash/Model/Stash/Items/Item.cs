using System.Collections.Generic;

namespace PoEPublicStash.Model
{
    public abstract class Item
    {
        public class Socket
        {
            public int group { get; set; }
            public string attr { get; set; }
            public string sColour { get; set; }
        }

        public class Property
        {
            public string name { get; set; }
            public IEnumerable<IEnumerable<object>> values { get; set; }
            public int displayMode { get; set; }
            public int type { get; set; }
        }

        public class AdditionalProperty
        {
            public string name { get; set; }
            public IEnumerable<IEnumerable<object>> values { get; set; }
            public int displayMode { get; set; }
            public int progress { get; set; }
        }

        public class Requirement
        {
            public string name { get; set; }
            public IEnumerable<IEnumerable<object>> values { get; set; }
            public int displayMode { get; set; }
        }

        public class NextLevelRequirement
        {
            public string name { get; set; }
            public IEnumerable<IEnumerable<object>> values { get; set; }
            public int displayMode { get; set; }
        }
    }
}
