using System;
using System.Collections.Generic;

namespace Elasticsearch.Net_1_7_2
{
	public class CallMetrics
	{
		public string Path { get; set; }
		public long SerializationTime { get; set; }
		public long DeserializationTime { get; set; }
		public DateTime StartedOn { get; set; }
		public DateTime CompletedOn { get; set; }
		public List<RequestMetrics> Requests { get; set; }
	}
}