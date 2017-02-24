﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Resolvers;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.ObjectInitializer.Search
{
	[TestFixture]
	public class SearchRequestUntypedTests : BaseJsonTests
	{
		private readonly IElasticsearchResponse _status;

		public SearchRequestUntypedTests()
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

			var request = new SearchRequest
			{
				From = 0,
				Size = 20,
				Query = query
				
			};
			var response = this._client.Search<ElasticsearchProject>(request);
			this._status = response.ConnectionStatus;
		}

		[Test]
		public void Url()
		{
			this._status.RequestUrl.Should().EndWith("/nest_test_data/_search");
			this._status.RequestMethod.Should().Be("POST");
		}
	
	}
}
