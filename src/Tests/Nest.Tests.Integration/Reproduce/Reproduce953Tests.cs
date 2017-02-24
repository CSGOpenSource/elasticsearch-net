using System.Text;
using Elasticsearch.Net_1_7_2.Connection;
using Elasticsearch.Net_1_7_2.ConnectionPool;
using FluentAssertions;
using Nest_1_7_2.Tests.Integration;
using Nest_1_7_2.Tests.MockData;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nest_1_7_2.Tests.Integration.Reproduce
{
	[TestFixture]
	public class Reproduce953Tests 
	{
		[Test]
		public void Calling_Refresh_UsingHttpClientConnection_DoesNotThrow()
		{

			var settings = ElasticsearchConfiguration.Settings()
				.EnableCompressedResponses(true);
			var connection = new HttpClientConnection(settings);
			var client = new ElasticClient(settings, connection: connection);
			
			Assert.DoesNotThrow(()=> client.Refresh());
			Assert.DoesNotThrow(()=> client.Get<ElasticsearchProject>(NestTestData.Data.First().Id));
			Assert.DoesNotThrow(()=> client.Ping());

		}
		
		
	}
}
