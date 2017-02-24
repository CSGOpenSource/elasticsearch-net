using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.ObjectInitializer.Scroll
{
	[TestFixture]
	public class ScrollRequestTests : BaseJsonTests
	{
		private readonly IElasticsearchResponse _status;

		public ScrollRequestTests()
		{
			var request = new ScrollRequest("scroll-id", "5m");
			var response = this._client.Scroll<ElasticsearchProject>(request);
			this._status = response.ConnectionStatus;
		}

		[Test]
		public void Url()
		{
			this._status.RequestUrl.Should().EndWith("/_search/scroll?scroll=5m");
			this._status.RequestMethod.Should().Be("POST");
		}
		
		[Test]
		public void ScrollBody()
		{
			this._status.Request.Utf8String().Should().Be("scroll-id");
		}
	}

}
