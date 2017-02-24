using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class FilterFacet : Facet
	{
		[JsonProperty(PropertyName = "count")]
		public long Count { get; internal set; }
	}
}
