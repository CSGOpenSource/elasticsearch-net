using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{

	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof(ReadAsTypeConverter<MatchAllQuery>))]
	public interface IMatchAllQuery : IQuery
	{
		[JsonProperty(PropertyName = "boost")]
		double? Boost { get; }

		[JsonProperty(PropertyName = "norm_field")]
		string NormField { get; }
	}

	public class MatchAllQuery : PlainQuery, IMatchAllQuery
	{
		public double? Boost { get; internal set; }

		public string NormField { get; internal set; }

		public string Name { get; set; }

		bool IQuery.IsConditionless { get { return false; } }

		protected override void WrapInContainer(IQueryContainer container)
		{
			container.MatchAllQuery = this;
		}
	}
}
