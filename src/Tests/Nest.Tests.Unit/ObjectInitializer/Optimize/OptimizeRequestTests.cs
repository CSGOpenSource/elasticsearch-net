﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.ObjectInitializer.Optimize
{
	[TestFixture]
	public class OptimizeRequestTests : BaseJsonTests
	{
		private readonly IElasticsearchResponse _status;

		public OptimizeRequestTests()
		{
			var request = new OptimizeRequest(typeof(ElasticsearchProject))
			{
				ExpandWildcards = ExpandWildcards.Open
			};
			//TODO Index(request) does not work as expected
			var response = this._client.Optimize(request);
			this._status = response.ConnectionStatus;
		}

		[Test]
		public void Url()
		{
			this._status.RequestUrl.Should().EndWith("/nest_test_data/_optimize?expand_wildcards=open");
			this._status.RequestMethod.Should().Be("POST");
		}
		
	}

}
