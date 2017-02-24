using System.Collections.Generic;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{

	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof(ReadAsTypeConverter<ValueCountAggregator>))]
	public interface IValueCountAggregator : IMetricAggregator
	{
	}
	
	public class ValueCountAggregator : MetricAggregator, IValueCountAggregator
	{
	}

	public class ValueCountAggregationDescriptor<T> : MetricAggregationBaseDescriptor<ValueCountAggregationDescriptor<T>, T>, IValueCountAggregator where T : class
	{
		
	}
}