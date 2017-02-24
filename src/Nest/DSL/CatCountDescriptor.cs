﻿using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ICatCountRequest : IRequest<CatCountRequestParameters>
	{
	}

	public partial class CatCountRequest : BasePathRequest<CatCountRequestParameters>, ICatCountRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatCountRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}

	public partial class CatCountDescriptor : BasePathDescriptor<CatCountDescriptor, CatCountRequestParameters>, ICatCountRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatCountRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}
}
