﻿
using Elasticsearch.Net_1_7_2;
using Elasticsearch.Net_1_7_2.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	internal static class NodesHotThreadsPathInfo
	{
		public static void Update(IConnectionSettingsValues settings, ElasticsearchPathInfo<NodesHotThreadsRequestParameters> pathInfo, INodesHotThreadsRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.GET;
		}
	}

	public interface INodesHotThreadsRequest 
		: INodeIdOptionalPath<NodesHotThreadsRequestParameters>
	{
	}

	public partial class NodesHotThreadsRequest 
		: NodeIdOptionalPathBase<NodesHotThreadsRequestParameters>, INodesHotThreadsRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<NodesHotThreadsRequestParameters> pathInfo)
		{
			NodesHotThreadsPathInfo.Update(settings, pathInfo, this);
		}
	}

	public partial class NodesHotThreadsDescriptor 
		: NodeIdOptionalPathBase<NodesHotThreadsRequestParameters>, INodesHotThreadsRequest
	{
		private INodesHotThreadsRequest Self { get { return this; } }

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<NodesHotThreadsRequestParameters> pathInfo)
		{
			NodesHotThreadsPathInfo.Update(settings, pathInfo, this.Self);
		}
	}
}
