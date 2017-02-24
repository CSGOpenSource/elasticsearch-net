using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject]
	public class CatMasterRecord : ICatRecord
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("ip")]
		public string Ip { get; set; }

		[JsonProperty("node")]
		public string Node { get; set; }
	}
}