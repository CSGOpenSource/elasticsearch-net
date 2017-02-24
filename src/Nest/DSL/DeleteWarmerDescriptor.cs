﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IDeleteWarmerRequest : IIndicesOptionalTypesNamePath<DeleteWarmerRequestParameters> { }

	internal static class DeleteWarmerPathInfo
	{
		public static void Update(ElasticsearchPathInfo<DeleteWarmerRequestParameters> pathInfo, IDeleteWarmerRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.DELETE;
		}
	}
	
	public partial class DeleteWarmerRequest : IndicesOptionalTypesNamePathBase<DeleteWarmerRequestParameters>, IDeleteWarmerRequest
	{
		public DeleteWarmerRequest(string name)
		{
			this.Name = name;
		}

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<DeleteWarmerRequestParameters> pathInfo)
		{
			DeleteWarmerPathInfo.Update(pathInfo, this);
		}
	}

	[DescriptorFor("IndicesDeleteWarmer")]
	public partial class DeleteWarmerDescriptor : IndicesOptionalTypesNamePathDescriptor<DeleteWarmerDescriptor, DeleteWarmerRequestParameters>, IDeleteWarmerRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<DeleteWarmerRequestParameters> pathInfo)
		{
			DeleteWarmerPathInfo.Update(pathInfo, this);
		}
	}
}
