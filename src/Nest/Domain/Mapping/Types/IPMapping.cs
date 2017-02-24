using System.Collections.Generic;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;
using System;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization.OptIn)]
	public class IPMapping : IElasticType
	{
		public PropertyNameMarker Name { get; set; }

		[JsonProperty("index_name")]
		public string IndexName { get; set; }

		[JsonProperty("type")]
		public virtual TypeNameMarker Type { get { return new TypeNameMarker { Name = "ip" }; } }

		[JsonProperty("similarity")]
		public string Similarity { get; set; }

		[JsonProperty("store")]
		public bool? Store { get; set; }

		[JsonProperty("index"), JsonConverter(typeof(YesNoBoolConverter))]
		public bool? Index { get; set; }

		[JsonProperty("precision_step")]
		public int? PrecisionStep { get; set; }

		[JsonProperty("boost")]
		public double? Boost { get; set; }

		[JsonProperty("null_value")]
		public string NullValue { get; set; }

		[JsonProperty("include_in_all")]
		public bool? IncludeInAll { get; set; }
	}
}