using System;
using AutoPoco.Engine;

namespace Nest_1_7_2.Tests.MockData.DataSources
{
	public class AgeSource : DatasourceBase<int>
	{
		private Random mRandom = new Random(1337);
		public override int Next(IGenerationSession session)
		{
			int f = mRandom.Next(18, 99);
			return f;
		}

	}
}