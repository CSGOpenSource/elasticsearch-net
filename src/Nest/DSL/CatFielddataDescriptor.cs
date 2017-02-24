﻿using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ICatFielddataRequest : IRequest<CatFielddataRequestParameters>
	{
	}

	public partial class CatFielddataRequest : BasePathRequest<CatFielddataRequestParameters>, ICatFielddataRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatFielddataRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}

	public partial class CatFielddataDescriptor : BasePathDescriptor<CatFielddataDescriptor, CatFielddataRequestParameters>, ICatFielddataRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatFielddataRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}
}
