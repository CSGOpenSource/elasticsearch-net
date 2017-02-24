﻿using System;
using Elasticsearch.Net_1_7_2;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.Core.Scroll
{
	[TestFixture]
	public class ScrollRequestTests : BaseJsonTests
	{
		[Test]
		public void ScrollIdGoesInBody()
		{
			var result = this._client.Scroll<ElasticsearchProject>(s => s
				.Scroll("4m")
				.ScrollId("INBODY")
			);
			var status = result.ConnectionStatus;
			var uri = new Uri(status.RequestUrl);
			Assert.AreEqual("/_search/scroll", uri.AbsolutePath);
			Assert.AreEqual("?scroll=4m", uri.Query);
			StringAssert.AreEqualIgnoringCase("POST", status.RequestMethod);
			Assert.AreEqual("INBODY", status.Request.Utf8String());
		}

	}
}