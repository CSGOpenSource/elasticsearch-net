﻿using NUnit.Framework;
using Nest_1_7_2.Tests.MockData.Domain;

namespace Nest_1_7_2.Tests.Integration.Core.Map.TtlField
{
	[TestFixture]
	public class TtlFieldTests : BaseMappingTests
	{
		[Test]
		public void TtlFieldSerializes()
		{
			var result = this.Client.Map<ElasticsearchProject>(m => m
				.TtlField(t => t
					.Enable(false)
					.Default("1d")
				)
			);
			this.DefaultResponseAssertations(result);
		}
	}
}
