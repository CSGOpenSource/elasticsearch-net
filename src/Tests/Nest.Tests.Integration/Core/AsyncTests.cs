﻿using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Integration.Core
{
	[TestFixture]
	public class AsyncTests : IntegrationTests
	{

		[Test]
		public async void TestIndex()
		{
			var newProject = new ElasticsearchProject
			{
				Name = "COBOLES", //COBOL ES client ?
			};
			var t = await  this.Client.IndexAsync<ElasticsearchProject>(newProject);
			Assert.True(t.IsValid);
		}
		
	}
}
