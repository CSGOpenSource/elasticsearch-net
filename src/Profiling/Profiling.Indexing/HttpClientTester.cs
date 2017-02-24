using System;
using System.Collections.Generic;
using Elasticsearch.Net_1_7_2.Connection;
using Nest;

namespace Profiling.Indexing
{
	public class HttpClientTester : Tester
	{
		public override IElasticClient CreateClient(string indexName)
		{
			var settings = this.CreateSettings(indexName, 9200);
			var client = new ElasticClient(settings, new HttpClientConnection(settings));
			return client;
		}
		

	}
}
