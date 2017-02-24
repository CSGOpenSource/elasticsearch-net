namespace Nest_1_7_2
{
	public class StatsMetric : IMetricAggregation
	{
		public long Count { get; set; }
		public double? Min { get; set; }
		public double? Max { get; set; }
		public double? Average { get; set; }
		public double? Sum { get; set; }
	}
}