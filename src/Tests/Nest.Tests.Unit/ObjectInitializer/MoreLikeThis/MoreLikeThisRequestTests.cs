﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Resolvers;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.ObjectInitializer.MoreLikeThis
{
	[TestFixture]
	public class MoreLikeThisRequestTests : BaseJsonTests
	{
		private readonly IElasticsearchResponse _status;

		public MoreLikeThisRequestTests()
		{
			QueryContainer query = new TermQuery()
			{
				Field = Property.Path<ElasticsearchProject>(p=>p.Name),
				Value = "value"
			} && new PrefixQuery()
			{
				Field = "prefix_field", 
				Value = "prefi", 
				Rewrite = RewriteMultiTerm.ConstantScoreBoolean
			};
			var search = new SearchRequest
			{
				From = 0,
				Size = 20,
				Query = query,
				Filter = new FilterContainer(new BoolFilter
				{
					Cache = true,
					Must = new FilterContainer[]
					{
						new TermFilter { Field = "value", Value = "asdasd"}
					}
				}),
				TrackScores = true,
				Explain = true,
				Sort = new List<KeyValuePair<PropertyPathMarker, ISort>>()
				{
					new KeyValuePair<PropertyPathMarker, ISort>("field", new Sort { Order = SortOrder.Ascending, Missing = "_first"})
				}
			};
			var request = new MoreLikeThisRequest("some-index", "the-type","document-id-21")
			{
				Search = search,
				MaxDocFreq = 2

			};
			var response = this._client.MoreLikeThis<ElasticsearchProject>(request);
			this._status = response.ConnectionStatus;
		}

		[Test]
		public void Url()
		{
			this._status.RequestUrl.Should().EndWith("/some-index/the-type/document-id-21/_mlt?max_doc_freq=2");
			this._status.RequestMethod.Should().Be("POST");
		}
		
		[Test]
		public void MoreLikeThisBody()
		{
			this.JsonEquals(this._status.Request, MethodBase.GetCurrentMethod());
		}
	}
}
