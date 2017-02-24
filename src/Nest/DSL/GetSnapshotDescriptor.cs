using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IGetSnapshotRequest : IRepositorySnapshotPath<GetSnapshotRequestParameters> { }

	internal static class GetSnapshotPathInfo
	{
		public static void Update(ElasticsearchPathInfo<GetSnapshotRequestParameters> pathInfo, IGetSnapshotRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.GET;
		}
	}
	
	public partial class GetSnapshotRequest : RepositorySnapshotPathBase<GetSnapshotRequestParameters>, IGetSnapshotRequest
	{
		public GetSnapshotRequest(string repository, string snapshot) : base(repository, snapshot) { }

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<GetSnapshotRequestParameters> pathInfo)
		{
			GetSnapshotPathInfo.Update(pathInfo, this);
		}
	}

	[DescriptorFor("SnapshotGet")]
	public partial class GetSnapshotDescriptor : RepositorySnapshotPathDescriptor<GetSnapshotDescriptor, GetSnapshotRequestParameters>, IGetSnapshotRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<GetSnapshotRequestParameters> pathInfo)
		{
			GetSnapshotPathInfo.Update(pathInfo, this);
		}

	}
}
