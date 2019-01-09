using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items
{
    public abstract class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("typeLine")]
        public string TypeLine { get; set; }

        [JsonProperty("frameType")]
        public int FrameType { get; set; }

        [JsonProperty("ilvl")]
        public int Ilvl { get; set; }

        [JsonProperty("identified")]
        public bool Identified { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("w")]
        public int W { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        public class Socket
        {
            [JsonProperty("group")]
            public int Group { get; set; }

            [JsonProperty("attr")]
            public string Attr { get; set; }

            [JsonProperty("sColour")]
            public string SColour { get; set; }
        }

        public class Property
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("values")]
            public IEnumerable<IEnumerable<object>> Values { get; set; }

            [JsonProperty("displayMode")]
            public int DisplayMode { get; set; }

            [JsonProperty("type")]
            public int Type { get; set; }
        }

        public class AdditionalProperty
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("values")]
            public IEnumerable<IEnumerable<object>> Values { get; set; }

            [JsonProperty("displayMode")]
            public int DisplayMode { get; set; }

            [JsonProperty("progress")]
            public int Progress { get; set; }
        }

        public class Requirement
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("values")]
            public IEnumerable<IEnumerable<object>> Values { get; set; }

            [JsonProperty("displayMode")]
            public int DisplayMode { get; set; }
        }

        public class NextLevelRequirement
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("values")]
            public IEnumerable<IEnumerable<object>> Values { get; set; }

            [JsonProperty("displayMode")]
            public int DisplayMode { get; set; }
        }
    }
}