using System.Collections.Generic;

namespace Elasticsearch.Net_1_7_2.Tests.Unit.Memory.Helpers
{
	public interface IMemorySetup<T> where T : class
	{
		List<TrackableMemoryStream> CreatedMemoryStreams { get; }
		TrackableMemoryStream ResponseStream { get; }
		ElasticsearchResponse<T> Result { get; set; }
	}
}