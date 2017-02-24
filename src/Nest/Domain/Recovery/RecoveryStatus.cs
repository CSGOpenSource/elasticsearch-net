using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class RecoveryStatus
	{
		[JsonProperty("shards")]
		public IEnumerable<ShardRecovery> Shards { get; internal set; }
	}
}