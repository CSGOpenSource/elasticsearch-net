﻿using NUnit.Framework;
using Nest_1_7_2.Tests.MockData.Domain;

namespace Nest_1_7_2.Tests.Unit.Search.Filter.Singles
{
	[TestFixture]
	public class MatchAllFilterJson
	{
		[Test]
		public void MatchAllFilter()
		{
			var s = new SearchDescriptor<ElasticsearchProject>()
				.From(0)
				.Size(10)
				.Filter(f=>f.MatchAll());
				
			var json = TestElasticClient.Serialize(s);
			var expected = @"{ from: 0, size: 10, 
				filter : {
						match_all : {}
					}
			}";
			Assert.True(json.JsonEquals(expected), json);		
		}
	}
}
