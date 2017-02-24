using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
    [JsonObject]
    public class MultiHit<T> where T : class
    {
        [JsonProperty("docs")]
        public IEnumerable<Hit<T>> Hits { get; internal set; }
    }
}
