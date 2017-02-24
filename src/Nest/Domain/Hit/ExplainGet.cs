using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Domain;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject]
	public class ExplainGet<T> where T : class
	{
		[JsonProperty(PropertyName = "found")]
		public bool Found { get; internal set; }
		[JsonProperty(PropertyName = "_source")]
		public T Source { get; internal set; }

		[JsonProperty(PropertyName = "fields")]
		internal IDictionary<string, object> _fields { get; set; }

	}
}
