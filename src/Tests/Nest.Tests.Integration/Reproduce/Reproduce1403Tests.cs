using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Elasticsearch.Net_1_7_2;

namespace Nest_1_7_2.Tests.Integration.Reproduce
{
	[TestFixture]
	public class Reproduce1403Tests : IntegrationTests
	{
		[Test]
		public void ExtendedStatsNotReadToCompletion()
		{
			var result = this.Client.Search<ElasticsearchProject>(s => s
				.SearchType(SearchType.Count)
				.Aggregations(a => a
					.ExtendedStats("a", stats => stats.Field(p => p.LongValue))
					.ExtendedStats("b", stats => stats.Field(p => p.LOC))
				)
			);

			result.IsValid.Should().BeTrue();
			result.Aggregations.Count.Should().Be(2);
		}
	}
}
