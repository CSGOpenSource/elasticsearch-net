using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;
using FluentAssertions;

namespace Nest_1_7_2.Tests.Integration.Reproduce
{
	/// <summary>
	/// tests to reproduce reported errors
	/// </summary>
	[TestFixture]
	public class Reproduce723Tests : IntegrationTests
	{

		/// <summary>
		/// https://github.com/Mpdreamz/NEST/issues/723
		/// </summary>
		[Test]
		public void GetInvalidIndexShouldReturnNull()
		{
			const string indexName = "indexthatdoesnotexist";
			var elasticSearchProject = this.Client.Source<ElasticsearchProject>(4, indexName);

			elasticSearchProject.Should().BeNull();
		}
		
		[Test]
		public void GetInvalidIndexShouldThrow_OnClientThatThrows()
		{
			const string indexName = "indexthatdoesnotexist";
			var e = Assert.Throws<ElasticsearchServerException>(() => this.ClientThatThrows.Source<ElasticsearchProject>(4, indexName));
			e.ExceptionType.Should().Be("IndexMissingException");

		}

	}
}
