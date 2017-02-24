using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IOpenIndexRequest : IIndexPath<OpenIndexRequestParameters> { }

	internal static class OpenIndexPathInfo
	{
		public static void Update(ElasticsearchPathInfo<OpenIndexRequestParameters> pathInfo, IOpenIndexRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.POST;
		}
	}
	
	public partial class OpenIndexRequest : IndexPathBase<OpenIndexRequestParameters>, IOpenIndexRequest
	{
		public OpenIndexRequest(IndexNameMarker index) : base(index) { }

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<OpenIndexRequestParameters> pathInfo)
		{
			OpenIndexPathInfo.Update(pathInfo, this);
		}
	}

	[DescriptorFor("IndicesOpen")]
	public partial class OpenIndexDescriptor : IndexPathDescriptorBase<OpenIndexDescriptor, OpenIndexRequestParameters>, IOpenIndexRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<OpenIndexRequestParameters> pathInfo)
		{
			OpenIndexPathInfo.Update(pathInfo, this);
		}
	}
}
