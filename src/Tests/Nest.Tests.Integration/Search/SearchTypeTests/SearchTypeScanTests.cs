using System.Linq;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Tests.MockData;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Integration.Search.SearchTypeTests
{
	[TestFixture]
	public class SearchTypeScanTests : IntegrationTests
	{
		private string _LookFor = NestTestData.Data.First().Followers.First().FirstName;

		[Test]
		public void SearchTypeScanWithoutScrollIsInvalid()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s=>s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f=>f.Name)
				.SearchType(SearchType.Scan)
			);
			Assert.False(queryResults.IsValid);
			var e = queryResults.ConnectionStatus.OriginalException as ElasticsearchServerException;
			e.Should().NotBeNull();
			e.Message.Should().Contain("Scroll must be provided when scanning");
		}
		[Test]
		public void SearchTypeScan()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s => s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f => f.Name)
				.SearchType(SearchType.Scan)
				.Scroll("2s")
			);
			Assert.True(queryResults.IsValid);
			Assert.False(queryResults.Documents.Any());
			Assert.IsNotNullOrEmpty(queryResults.ScrollId);

		}
		[Test]
		public void SearchScrollOnly()
		{
			var queryResults = this.Client.Search<ElasticsearchProject>(s => s
				.From(0)
				.Size(10)
				.MatchAll()
				.Fields(f => f.Name)
				.Scroll("2s")
			);
			Assert.True(queryResults.IsValid);
			Assert.True(queryResults.Hits.Any());
			Assert.IsNotNullOrEmpty(queryResults.ScrollId);
		}
	}
}