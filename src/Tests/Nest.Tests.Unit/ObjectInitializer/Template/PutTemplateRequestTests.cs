﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.ObjectInitializer.Template
{
	[TestFixture]
	public class PutTemplateRequestTests : BaseJsonTests
	{
		private readonly IElasticsearchResponse _status;

		public PutTemplateRequestTests()
		{
			var request = new PutTemplateRequest("a-template")
			{
				FlatSettings = true,
				TemplateMapping = new TemplateMapping
				{
					Template = "nest-*",
					Aliases = new FluentDictionary<string, ICreateAliasOperation>
					{
						{"my-alias", new CreateAliasOperation
						{
							Filter = Filter<ElasticsearchProject>.Term("name", "term")
						}}
					}
				}

			};
			var response = this._client.PutTemplate(request);
			this._status = response.ConnectionStatus;
		}

		[Test]
		public void Url()
		{
			this._status.RequestUrl.Should().EndWith("/_template/a-template?flat_settings=true");
			this._status.RequestMethod.Should().Be("PUT");
		}
		
		[Test]
		public void PutTemplateBody()
		{
			this.JsonEquals(this._status.Request, MethodBase.GetCurrentMethod());
		}
	}

}
