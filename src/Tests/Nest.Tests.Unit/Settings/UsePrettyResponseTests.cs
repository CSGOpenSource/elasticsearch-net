using System;
using Elasticsearch.Net_1_7_2;
using Elasticsearch.Net_1_7_2.Connection;
using FluentAssertions;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.Settings
{
	[TestFixture]
	public class UsePrettyResponses : BaseJsonTests
	{
		[Test]
		public void UsePrettyResponsesShouldSurviveUrlModififications()
		{
			var settings = new ConnectionSettings(UnitTestDefaults.Uri, UnitTestDefaults.DefaultIndex)
				.UsePrettyResponses();
			var connection = new InMemoryConnection(settings);
			var client = new ElasticClient(settings, connection);

			var r = client.ClusterHealth(h=>h.Level(Level.Cluster));
			var u = new Uri(r.ConnectionStatus.RequestUrl);
			u.AbsolutePath.Should().StartWith("/_cluster/health");
			u.Query.Should().Contain("level=cluster");

			u.Query.Should().Contain("pretty=true");
		}
		
	}
}