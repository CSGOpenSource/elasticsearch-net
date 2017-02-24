using System.Collections.Generic;

namespace Nest_1_7_2
{
	public interface IBucketAggregation : IAggregation
	{
		IDictionary<string, IAggregation> Aggregations { get; }
	}
}