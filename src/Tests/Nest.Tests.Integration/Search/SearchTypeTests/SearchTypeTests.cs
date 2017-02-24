using System.Linq;
using Elasticsearch.Net_1_7_2;
using Nest_1_7_2.Tests.MockData;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Integration.Search.SearchTypeTests
{
	[TestFixture]
	public class SearchTypeTests : IntegrationTests
	{
		private string _LookFor = NestTestData.Data.First().Followers.First().FirstName;

		[Test]
		public void SearchQueryAndFetch()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s=>s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f=>f.Name)
				.SearchType(SearchType.QueryAndFetch)
				
			);
			Assert.True(queryResults.IsValid);
			Assert.True(queryResults.Hits.Any());
		}
		[Test]
		public void SearchQueryThenFetch()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s => s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f => f.Name)
				.SearchType(SearchType.QueryThenFetch)

			);
			Assert.True(queryResults.IsValid);
			Assert.True(queryResults.Hits.Any());
		}

		[Test]
		public void SearchDfsQueryAndFetch()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s => s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f => f.Name)
				.SearchType(SearchType.DfsQueryAndFetch)

			);
			Assert.True(queryResults.IsValid);
			Assert.True(queryResults.Hits.Any());
		}
		[Test]
		public void SearchDfsQueryThenFetch()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s => s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f => f.Name)
				.SearchType(SearchType.DfsQueryThenFetch)

			);
			Assert.True(queryResults.IsValid);
			Assert.True(queryResults.Hits.Any());
		}

	}
}