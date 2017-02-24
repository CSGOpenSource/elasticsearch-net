﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Nest_1_7_2.Tests.MockData.Domain;

namespace Nest_1_7_2.Tests.Unit.Search.Rescoring
{
	[TestFixture]
	public class RescoreTests : BaseJsonTests
	{
		[Test]
		public void RescoreSerializes()
		{
			var s = new SearchDescriptor<ElasticsearchProject>()
				.From(0)
				.Size(10)
				.MatchAll()
				.Rescore(r=>r
					.WindowSize(500)
					.RescoreQuery(rq=>rq
						.QueryWeight(1.0)
						.RescoreQueryWeight(2.0)
						.ScoreMode(ScoreMode.Multiply)
						.Query(q=>q.Term(p=>p.Name, "nest"))
					)
				);
			this.JsonEquals(s, System.Reflection.MethodInfo.GetCurrentMethod());
		}

	}
}
