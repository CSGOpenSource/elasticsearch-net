using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class RecoveryFileDetails
	{
		[JsonProperty("name")]
		public string Name { get; internal set; }

		[JsonProperty("length")]
		public long Length { get; internal set; }

		[JsonProperty("recovered")]
		public long Recovered { get; internal set; }

	}
}