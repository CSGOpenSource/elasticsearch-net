using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IClusterHealthRequest : IIndicesOptionalPath<ClusterHealthRequestParameters> { }

	internal static class ClusterHealthPathInfo
	{
		public static void Update(ElasticsearchPathInfo<ClusterHealthRequestParameters> pathInfo, IClusterHealthRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.GET;
		}
	}
	
	public partial class ClusterHealthRequest : IndicesOptionalPathBase<ClusterHealthRequestParameters>, IClusterHealthRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<ClusterHealthRequestParameters> pathInfo)
		{
			ClusterHealthPathInfo.Update(pathInfo, this);
		}
	}
	public partial class ClusterHealthDescriptor : IndicesOptionalPathDescriptor<ClusterHealthDescriptor, ClusterHealthRequestParameters>, IClusterHealthRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<ClusterHealthRequestParameters> pathInfo)
		{
			ClusterHealthPathInfo.Update(pathInfo, this);
		}
	}
}
