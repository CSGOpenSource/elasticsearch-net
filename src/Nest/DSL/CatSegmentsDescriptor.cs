﻿using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ICatSegmentsRequest : IRequest<CatSegmentsRequestParameters>
	{
	}

	public partial class CatSegmentsRequest : BasePathRequest<CatSegmentsRequestParameters>, ICatSegmentsRequest 
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatSegmentsRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}

	public partial class CatSegmentsDescriptor : BasePathDescriptor<CatSegmentsDescriptor, CatSegmentsRequestParameters>, ICatSegmentsRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatSegmentsRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}
}
