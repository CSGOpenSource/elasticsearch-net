﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.ObjectInitializer.Snapshots
{
	[TestFixture]
	public class CreateRepositoryRequestTests : BaseJsonTests
	{
		private readonly IElasticsearchResponse _status;

		public CreateRepositoryRequestTests()
		{
			var request = new CreateRepositoryRequest("repos")
			{
				Repository = new AzureRepository
				{
					Settings = new Dictionary<string, object>
					{
						{ "bucket", "my-bucket" },
						{ "compress", true },
						{ "concurrent_stream", 4 }
					}
				}
			};
			var response = this._client.CreateRepository(request);
			this._status = response.ConnectionStatus;
		}

		[Test]
		public void Url()
		{
			this._status.RequestUrl.Should().EndWith("/_snapshot/repos");
			this._status.RequestMethod.Should().Be("PUT");
		}
		
		[Test]
		public void CreateRepositoryBody()
		{
			this.JsonEquals(this._status.Request, MethodBase.GetCurrentMethod());
		}
	}
}
