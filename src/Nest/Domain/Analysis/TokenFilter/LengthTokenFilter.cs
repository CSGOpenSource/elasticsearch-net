﻿using Newtonsoft.Json;

namespace Nest_1_7_2
{
    /// <summary>
	/// A token filter of type length that removes words that are too long or too short for the stream.
    /// </summary>
    public class LengthTokenFilter : TokenFilterBase
    {
		public LengthTokenFilter()
            : base("length")
        {

        }

        [JsonProperty("min")]
        public int? Minimum { get; set; }

        [JsonProperty("max")]
        public int? Maximum { get; set; }
    }
}