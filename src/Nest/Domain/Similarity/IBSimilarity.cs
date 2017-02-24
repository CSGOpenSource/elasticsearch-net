using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nest_1_7_2
{
	public class IBSimilarity : SimilarityBase
	{
		public IBSimilarity()
		{
			this.Type = "IB";
		}

		[JsonProperty("distribution")]
		public string Distribution { get; set; }

		[JsonProperty("lambda")]
		public string Lambda { get; set; }
	}
}
