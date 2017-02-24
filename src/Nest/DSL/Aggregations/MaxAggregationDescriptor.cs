using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof(ReadAsTypeConverter<MaxAggregator>))]
	public interface IMaxAggregator : IMetricAggregator
	{
	}
	public class MaxAggregator : MetricAggregator, IMaxAggregator
	{
	}

	public class MaxAggregationDescriptor<T> : MetricAggregationBaseDescriptor<MaxAggregationDescriptor<T>, T>, IMaxAggregator where T : class
	{
		
	}
}
