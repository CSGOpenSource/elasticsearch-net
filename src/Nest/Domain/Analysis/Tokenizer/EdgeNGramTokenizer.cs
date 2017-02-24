﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	/// <summary>
	/// A tokenizer of type edgeNGram.
	/// </summary>
	public class EdgeNGramTokenizer : TokenizerBase
    {
		public EdgeNGramTokenizer()
        {
            Type = "edgeNGram";
        }

		[JsonProperty("min_gram")]
		public int? MinGram { get; set; }

		[JsonProperty("max_gram")]
		public int? MaxGram { get; set; }

		[JsonProperty("side")]
		public string Side { get; set; }

        [JsonProperty("token_chars")]
        public IList<string> TokenChars { get; set; }
    }
}