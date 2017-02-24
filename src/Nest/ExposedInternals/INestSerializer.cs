using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Elasticsearch.Net_1_7_2.Serialization;
using Newtonsoft.Json;

namespace Nest
{

	//TODO It would be very nice if we can get rid of this interface
	public interface INestSerializer : IElasticsearchSerializer
	{
		string SerializeBulkDescriptor(IBulkRequest bulkRequest);

		string SerializeMultiSearch(IMultiSearchRequest multiSearchRequest);

		string SerializeMultiPercolate(IMultiPercolateRequest multiPercolateRequest);

		T DeserializeInternal<T>(Stream stream, JsonConverter converter);
	}
}
