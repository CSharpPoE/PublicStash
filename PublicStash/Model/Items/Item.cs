using System.Collections.Generic;

namespace PathOfExile.Model.Items
{
    public abstract class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string typeLine { get; set; }
        public int frameType { get; set; }
        public int ilvl { get; set; }
        public bool identified { get; set; }
        public bool verified { get; set; }
        public string league { get; set; }
        public string icon { get; set; }
        public int h { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }

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