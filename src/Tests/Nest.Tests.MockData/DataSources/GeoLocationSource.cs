using System;
using System.Collections.Generic;
using System.Linq;
using AutoPoco.Engine;
using Nest_1_7_2.Tests.MockData.Domain;

namespace Nest_1_7_2.Tests.MockData.DataSources
{
	public class GeoLocationSource : DatasourceBase<Domain.CustomGeoLocation>
	{
		private Random mRandom = new Random(1337);
		public override Domain.CustomGeoLocation Next(IGenerationSession session)
		{
			return session.Single<Domain.CustomGeoLocation>().Get();
		}

	}
}
