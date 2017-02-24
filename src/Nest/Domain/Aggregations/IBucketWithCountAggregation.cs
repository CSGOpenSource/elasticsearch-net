namespace Nest_1_7_2
{
	public interface IBucketWithCountAggregation : IBucketAggregation
	{
		long DocCount { get; }
	}
}