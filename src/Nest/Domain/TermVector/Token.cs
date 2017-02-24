﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
    [JsonObject]
    public class Token
    {
        [JsonProperty("end_offset")]
        public int EndOffset { get; internal set; }

        [JsonProperty("payload")]
        public string Payload { get; internal set; }

        [JsonProperty("position")]
        public int Position { get; internal set; }

        [JsonProperty("start_offset")]
        public int StartOffset { get; internal set; }
    }
}
