using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class RecoveryOrigin
	{
		[JsonProperty("id")]
		public string Id { get; internal set; }

		[JsonProperty("hostname")]
		public string HostName { get; internal set; }

		[JsonProperty("ip")]
		public string Ip { get; internal set; }

		[JsonProperty("name")]
		public string Name { get; internal set; }

	}
}