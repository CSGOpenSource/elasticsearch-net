using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nest_1_7_2
{
    [JsonObject]
    public class ShardSegmentRouting
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; internal set; }

        [JsonProperty(PropertyName = "primary")]
        public bool Primary { get; internal set; }

        [JsonProperty(PropertyName = "node")]
        public string Node { get; internal set; }
    }
}