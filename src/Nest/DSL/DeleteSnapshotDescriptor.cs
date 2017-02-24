﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IDeleteSnapshotRequest : IRepositorySnapshotPath<DeleteSnapshotRequestParameters> { }

	internal static class DeleteSnapshotPathInfo
	{
		public static void Update(ElasticsearchPathInfo<DeleteSnapshotRequestParameters> pathInfo, IDeleteSnapshotRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.DELETE;
		}
	}
	
	public partial class DeleteSnapshotRequest : RepositorySnapshotPathBase<DeleteSnapshotRequestParameters>, IDeleteSnapshotRequest
	{
		public DeleteSnapshotRequest(string repository, string snapshot) : base(repository, snapshot) { }

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<DeleteSnapshotRequestParameters> pathInfo)
		{
			DeleteSnapshotPathInfo.Update(pathInfo, this);
		}
	}
	[DescriptorFor("SnapshotDelete")]
	public partial class DeleteSnapshotDescriptor : RepositorySnapshotPathDescriptor<DeleteSnapshotDescriptor, DeleteSnapshotRequestParameters>, IDeleteSnapshotRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<DeleteSnapshotRequestParameters> pathInfo)
		{
			DeleteSnapshotPathInfo.Update(pathInfo, this);
		}

	}
}
