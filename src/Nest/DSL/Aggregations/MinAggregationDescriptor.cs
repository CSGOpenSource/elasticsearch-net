using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof(ReadAsTypeConverter<MinAggregator>))]
	public interface IMinAggregator : IMetricAggregator
	{
	}

	public class MinAggregator : MetricAggregator, IMinAggregator
	{
	}

	public class MinAggregationDescriptor<T> : MetricAggregationBaseDescriptor<MinAggregationDescriptor<T>, T>, IMinAggregator where T : class
	{
		
	}
}
