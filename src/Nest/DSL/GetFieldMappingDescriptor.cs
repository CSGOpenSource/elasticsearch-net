using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IGetFieldMappingRequest : IIndicesOptionalTypesOptionalFieldsPath<GetFieldMappingRequestParameters> { }
	public interface IGetFieldMappingRequest<T> : IGetFieldMappingRequest where T : class { }

	internal static class GetFieldMappingPathInfo
	{
		public static void Update(ElasticsearchPathInfo<GetFieldMappingRequestParameters> pathInfo, IGetFieldMappingRequest request)
		{
			pathInfo.HttpMethod = PathInfoHttpMethod.GET;
		}
	}
	
	public partial class GetFieldMappingRequest : IndicesOptionalTypesOptionalFieldsPathBase<GetFieldMappingRequestParameters>, IGetFieldMappingRequest
	{
		public GetFieldMappingRequest(params PropertyPathMarker[] fields) : base(fields) {}

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<GetFieldMappingRequestParameters> pathInfo)
		{
			GetFieldMappingPathInfo.Update(pathInfo, this);
		}
	}
	
	public partial class GetFieldMappingRequest<T> : IndicesOptionalTypesOptionalFieldsPathBase<GetFieldMappingRequestParameters, T>, IGetFieldMappingRequest
		where T : class
	{
		public GetFieldMappingRequest(params PropertyPathMarker[] fields) : base(fields) { }

		public GetFieldMappingRequest(params Expression<Func<T, object>>[] fields) : base(fields) { }

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<GetFieldMappingRequestParameters> pathInfo)
		{
			GetFieldMappingPathInfo.Update(pathInfo, this);
		}
	}

	[DescriptorFor("IndicesGetFieldMapping")]
	public partial class GetFieldMappingDescriptor<T> : IndicesOptionalTypesOptionalFieldsPathDescriptor<GetFieldMappingDescriptor<T>, GetFieldMappingRequestParameters, T>, IGetFieldMappingRequest
		where T : class
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<GetFieldMappingRequestParameters> pathInfo)
		{
			GetFieldMappingPathInfo.Update(pathInfo, this);
		}
	}
}
