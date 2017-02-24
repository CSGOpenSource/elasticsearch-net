using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Integration.Debug
{
	[TestFixture]
	public class MemoryUsageTests 
	{
		[Test]
		public void DeserializeOfStreamDoesNotHoldACopyOfTheResponse()
		{
			var uri = ElasticsearchConfiguration.CreateBaseUri();
			var settings = new ConnectionSettings(uri, ElasticsearchConfiguration.DefaultIndex);
			IElasticClient client = new ElasticClient(settings);
			
			var results = client.Search<ElasticsearchProject>(s => s.MatchAll());


		}

	}
}
