using System.Collections.Generic;

namespace QuickPOE.Model
{


    public abstract class AbstractItem
    {
        internal class Socket
        {
            public int group { get; set; }
            public string attr { get; set; }
            public string sColour { get; set; }
        }

        internal class Property
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

        internal class Requirement
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
