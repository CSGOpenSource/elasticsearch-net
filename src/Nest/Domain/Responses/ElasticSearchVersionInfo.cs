using System;
using Newtonsoft.Json;

namespace Nest_1_7_2
{

	public class ElasticsearchVersionInfo
	{
		public string Number { get; set; }

		[JsonProperty(PropertyName = "snapshot_build")]
		public bool IsSnapShotBuild { get; set; }

		[JsonProperty(PropertyName = "lucene_version")]
		public string LuceneVersion { get; set; }
	}
}
