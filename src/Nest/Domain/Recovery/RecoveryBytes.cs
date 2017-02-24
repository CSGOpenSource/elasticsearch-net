﻿using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class RecoveryBytes
	{
		
		[JsonProperty("total")]
		public long Total { get; internal set; }

		[JsonProperty("reused")]
		public long Reused { get; internal set; }

		[JsonProperty("recovered")]
		public long Recovered { get; internal set; }

		[JsonProperty("percent")]
		public string Percent { get; internal set; }

	}
}