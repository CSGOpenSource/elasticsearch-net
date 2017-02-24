using FluentAssertions;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.QueryParsers.Filter
{
	[TestFixture]
	public class PrefixFilterTests : ParseFilterTestsBase 
	{
		[Test]
		[TestCase("cacheName", "cacheKey", true)]
		public void Prefix_Deserializes(string cacheName, string cacheKey, bool cache)
		{
			var prefixFilter = this.SerializeThenDeserialize(cacheName, cacheKey, cache, 
				f=>f.Prefix,
				f=>f.Prefix(p=>p.Name, "elast")
				);

			prefixFilter.Field.Should().Be("name");
			prefixFilter.Prefix.Should().Be("elast");
		}
		
	}
}