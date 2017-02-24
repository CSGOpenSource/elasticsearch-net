using System;
using System.IO;
using Autofac;
using Autofac.Extras.FakeItEasy;
using Elasticsearch.Net_1_7_2.Connection;
using Elasticsearch.Net_1_7_2.Providers;
using Elasticsearch.Net_1_7_2.Tests.Unit.Stubs;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using Elasticsearch.Net_1_7_2.ConnectionPool;

namespace Elasticsearch.Net_1_7_2.Tests.Unit.ConnectionPools
{
	[TestFixture]
	public class SingleNodeConnectionPoolTests
	{
		private readonly ConnectionConfiguration _config;
		private ElasticsearchResponse<Stream> _ok;
		private ElasticsearchResponse<Stream> _bad;

		public SingleNodeConnectionPoolTests()
		{
			_config = new ConnectionConfiguration(new Uri("http://localhost:9200"))
				.MaximumRetries(2);

			_ok = FakeResponse.Ok(_config);
			_bad = FakeResponse.Any(_config, -1);


		}

		[Test]
		public void HttpsUri_UsingSsl_IsTrue()
		{
			Assert.IsTrue(new SingleNodeConnectionPool(new Uri("https://test1")).UsingSsl);
		}

		[Test]
		public void HttpUri_UsingSsl_IsFalse()
		{
			Assert.IsFalse(new SingleNodeConnectionPool(new Uri("http://test1")).UsingSsl);
		}
	}
}
