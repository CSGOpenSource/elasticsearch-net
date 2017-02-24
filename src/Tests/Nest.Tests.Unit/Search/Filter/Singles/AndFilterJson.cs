﻿using NUnit.Framework;
using Nest_1_7_2.Tests.MockData.Domain;

namespace Nest_1_7_2.Tests.Unit.Search.Filter.Singles
{
	[TestFixture]
	public class AndFilterJson
	{
		[Test]
		public void AndFilter()
		{
			var s = new SearchDescriptor<ElasticsearchProject>()
				.From(0)
				.Size(10)
				.Filter(filter=>filter
					.And(
						f=>f.MatchAll(),
						f=>f.Missing(p=>p.LOC)
					)
					
				);
				
			var json = TestElasticClient.Serialize(s);
			var expected = @"{ from: 0, size: 10, 
				filter : {
						""and"": {
							""filters"": [
								{
									""match_all"": {}
								},
								{
									""missing"": {
										""field"": ""loc""
									}
								}
							]
						}
					}
			}";
			Assert.True(json.JsonEquals(expected), json);		
		}
		[Test]
		public void AndFilterCacheNamed()
		{
			var s = new SearchDescriptor<ElasticsearchProject>()
				.From(0)
				.Size(10)
				.Filter(filter => filter.Cache(true).Name("and_filter")
					.And(
						f => f.MatchAll(),
						f => f.Missing(p => p.LOC)
					)

				);

			var json = TestElasticClient.Serialize(s);
			var expected = @"{ from: 0, size: 10, 
				filter : {
						""and"": {
							""filters"": [
								{
									""match_all"": {}
								},
								{
									""missing"": {
										""field"": ""loc""
									}
								}
							],
							_cache:true,
							_name:""and_filter""
						}
					}
			}";
			Assert.True(json.JsonEquals(expected), json);
		}
	}
}
