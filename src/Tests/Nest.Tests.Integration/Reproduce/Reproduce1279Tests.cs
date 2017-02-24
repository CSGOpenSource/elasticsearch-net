using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Nest_1_7_2.Tests.MockData.Domain;
using Newtonsoft.Json.Linq;

namespace Nest_1_7_2.Tests.Integration.Reproduce
{
	[TestFixture]
	public class Reproduce1279Tests : IntegrationTests
	{
		[Test]
		public void MultiSearchNullArgumentException()
		{
			var request = new MultiSearchRequest
			{
				Operations = new Dictionary<string, ISearchRequest>
				{
					{ "test", new SearchRequest
						{
							Query = new QueryContainer(new MatchAllQuery()),
							Types = new TypeNameMarker[] { typeof(Product), typeof(ElasticsearchProject) },
							TypeSelector = (o, h) => typeof(ElasticsearchProject)
						}
					}
				}
			};

			var result = Client.MultiSearch(request);
			result.IsValid.Should().BeTrue();
			var response = result.GetResponse<object>("test");
			var projects = response.Documents.OfType<ElasticsearchProject>().ToList();
			projects.Count.Should().BeGreaterThan(0);
		}
	}
}
