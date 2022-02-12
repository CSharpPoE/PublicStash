using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items
{
    public abstract class Item
    {
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("w")]
        public int W { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("support")]
        public bool? Support { get; set; }

        [JsonProperty("stackSize")]
        public int? StackSize { get; set; }

        [JsonProperty("maxStackSize")]
        public int? MaxStackSize { get; set; }

        [JsonProperty("stackSizeText")]
        public int? StackSizeText { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeLine")]
        public string TypeLine { get; set; }

        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("identified")]
        public bool Identified { get; set; }

        [JsonProperty("itemLevel")]
        public int? ItemLevel { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("frameType")]
        public int FrameType { get; set; }

        [JsonProperty("extended")]
        public Extended Extended { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

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

    public class Extended
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategories")]
        public string[] Subcategories { get; set; }

        [JsonProperty("prefixes")]
        public int Prefixes { get; set; }

        [JsonProperty("suffixes")]
        public int Suffixes { get; set; }
    }
}