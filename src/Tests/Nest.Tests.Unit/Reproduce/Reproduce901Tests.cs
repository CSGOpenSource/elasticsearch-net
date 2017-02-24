using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Elasticsearch.Net_1_7_2;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.Reproduce
{
	/// <summary>
	/// tests to reproduce reported errors
	/// </summary>
	[TestFixture]
	public class Reproduce901Tests : BaseJsonTests
	{
		private class MyClass
		{
			public MyEnum MyEnum { get; set; }
		}

		private enum MyEnum
		{
			Value1,
			Value2
		}

		[Test]
		public void EnumQueryDefaultsToInt()
		{
			var query = new SearchDescriptor<MyClass>()
				.Query(q => q.Term(p => p.MyEnum, MyEnum.Value2));
			this.JsonEquals(query, MethodBase.GetCurrentMethod());
		}

	}
}
