using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class IndexDocStats
	{
		[JsonProperty("num_docs")]
		public long NumberOfDocs { get; set; }
		[JsonProperty("max_docs")]
		public long MaximumDocs { get; set; }
		[JsonProperty("deleted_docs")]
		public long DeletedDocs { get; set; }
	}
}
