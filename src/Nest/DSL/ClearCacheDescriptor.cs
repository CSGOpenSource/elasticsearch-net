﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IClearCacheRequest : IIndicesOptionalPath<ClearCacheRequestParameters> { }

	internal static class ClearCachePathInfo
	{
		public static void Update(ElasticsearchPathInfo<ClearCacheRequestParameters> pathInfo, IClearCacheRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.POST;
		}
	}
	
	public partial class ClearCacheRequest : IndicesOptionalPathBase<ClearCacheRequestParameters>, IClearCacheRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<ClearCacheRequestParameters> pathInfo)
		{
			ClearCachePathInfo.Update(pathInfo, this);
		}
	}

	[DescriptorFor("IndicesClearCache")]
	public partial class ClearCacheDescriptor : IndicesOptionalPathDescriptor<ClearCacheDescriptor, ClearCacheRequestParameters>, IClearCacheRequest
	{

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<ClearCacheRequestParameters> pathInfo)
		{
			ClearCachePathInfo.Update(pathInfo, this);
		}
	}
}
