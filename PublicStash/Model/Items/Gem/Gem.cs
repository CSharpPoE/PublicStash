﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace PathOfExile.Model.Items.Gems
{
    public abstract class Gem : Item
    {
        [JsonProperty("support")]
        public bool Support { get; set; }

        [JsonProperty("properties")]
        public IEnumerable<Property> Properties { get; set; }

        [JsonProperty("additionalProperties")]
        public IEnumerable<AdditionalProperty> AdditionalProperties { get; set; }

        [JsonProperty("requirements")]
        public IEnumerable<Requirement> Requirements { get; set; }

        [JsonProperty("secDescrText")]
        public string SecDescrText { get; set; }

        [JsonProperty("explicitMods")]
        public IEnumerable<string> ExplicitMods { get; set; }

        [JsonProperty("descrText")]
        public string DescrText { get; set; }

        [JsonProperty("inventoryId")]
        public string InventoryId { get; set; }
    }
}