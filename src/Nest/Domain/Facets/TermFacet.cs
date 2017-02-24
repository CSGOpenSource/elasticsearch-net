﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
    [JsonObject]
    public class TermFacet : Facet, IFacet<TermItem>
    {
        [JsonProperty("missing")]
        public long Missing { get; internal set; }

        [JsonProperty("other")]
        public long Other { get; internal set; }

        [JsonProperty("total")]
        public long Total { get; internal set; }

        [JsonProperty("terms")]
        public IEnumerable<TermItem> Items { get; internal set; }
    }
    public class TermItem : FacetItem
    {
        [JsonProperty(PropertyName = "term")]
        public string Term { get; internal set; }
    }
}