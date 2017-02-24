using System.Linq;
using Nest_1_7_2.Tests.MockData;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;
using Elasticsearch.Net_1_7_2;

namespace Nest_1_7_2.Tests.Integration.Search
{
	[TestFixture]
	public class VersionTests : IntegrationTests
	{
		private string _LookFor = NestTestData.Data.First().Followers.First().FirstName;

		[Test]
		public void WithVersion()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s=>s
				.Version()
				.MatchAll() //not explicitly needed.
			);
			Assert.True(queryResults.IsValid);
			Assert.Greater(queryResults.Total, 0);
			Assert.True(queryResults.Hits.All(h => !h.Version.IsNullOrEmpty()));
		}
		[Test]
		public void NoVersion()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s => s
				   .Version(false)
				   .MatchAll() //not explicitly needed.
			   );

			Assert.True(queryResults.IsValid);
			Assert.Greater(queryResults.Total, 0);
			Assert.True(queryResults.Hits.All(h => h.Version.IsNullOrEmpty()));
		}
	}
}