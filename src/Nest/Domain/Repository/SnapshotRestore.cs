using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class SnapshotRestore
	{
		[JsonProperty("snapshot")]
		public string Name { get; internal set;  }
		[JsonProperty("indices")]
		public IEnumerable<string> Indices { get; internal set; }
		
		[JsonProperty("shards")]
		public ShardsMetaData Shards { get; internal set;  }
	}
}