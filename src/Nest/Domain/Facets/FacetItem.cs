using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public abstract class FacetItem
	{
		[JsonProperty("count")]
		public virtual long Count { get; internal set; }
	}
}