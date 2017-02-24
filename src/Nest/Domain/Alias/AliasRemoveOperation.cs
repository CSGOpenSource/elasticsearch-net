using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class AliasRemoveOperation
	{
		[JsonProperty("index")]
		public IndexNameMarker Index { get; set; }
		[JsonProperty("alias")]
		public string Alias { get; set; }
	}
}