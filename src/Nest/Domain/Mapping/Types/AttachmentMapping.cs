using System.Collections.Generic;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;
using System;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization.OptIn)]
	public class AttachmentMapping : IElasticType
	{
		public PropertyNameMarker Name { get; set; }

		[JsonProperty("type")]
		public virtual TypeNameMarker Type { get { return new TypeNameMarker { Name = "attachment" }; } }

		[JsonProperty("similarity")]
		public string Similarity { get; set; }

		[JsonProperty("fields"), JsonConverter(typeof(ElasticCoreTypeConverter))]
		public IDictionary<PropertyNameMarker, IElasticCoreType> Fields { get; set; }

		public AttachmentMapping()
		{
			this.Fields = new Dictionary<PropertyNameMarker, IElasticCoreType>();
		}

	}
}