using System.Linq;
using Nest_1_7_2.Tests.MockData;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;

namespace Nest_1_7_2.Tests.Integration.Search
{
	[TestFixture]
	public class DoRequestTests : IntegrationTests
	{
		[Test]
		public void DoRequestWithDynamicDictionaryAsType()
		{
			var d = this.Client.DoRequest<DynamicDictionary>("POST", "_search", new
			{

			});

			dynamic response = d.Response;
			int took = response.took;
			took.Should().BeGreaterThan(0);
			double maxScore = response.hits.max_score;
			maxScore.Should().Be(1.0);
		}

		[Test]
		public void DoRawDynamicDictionaryRequest()
		{
			var d = this.Client.Raw.Search(new
			{

			});

			dynamic response = d.Response;
			int took = response.took;
			took.Should().BeGreaterThan(0);
			double maxScore = response.hits.max_score;
			maxScore.Should().Be(1.0);
		}
		
	}
}
;