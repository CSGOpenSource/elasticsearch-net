using System.Collections.Generic;
namespace Nest_1_7_2
{
	public abstract class BucketAggregationBase : AggregationsHelper , IBucketAggregation
	{
		protected BucketAggregationBase() { }
		protected BucketAggregationBase(IDictionary<string, IAggregation> aggregations) : base(aggregations) { }
	}
}