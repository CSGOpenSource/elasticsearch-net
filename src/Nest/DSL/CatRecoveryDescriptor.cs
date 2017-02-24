﻿using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ICatRecoveryRequest : IRequest<CatRecoveryRequestParameters>
	{
	}

	public partial class CatRecoveryRequest : BasePathRequest<CatRecoveryRequestParameters>, ICatRecoveryRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatRecoveryRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}

	public partial class CatRecoveryDescriptor : BasePathDescriptor<CatRecoveryDescriptor, CatRecoveryRequestParameters>, ICatRecoveryRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatRecoveryRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}
}
