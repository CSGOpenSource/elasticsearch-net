using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ICatAllocationRequest : IRequest<CatAllocationRequestParameters>
	{
	}

	public partial class CatAllocationRequest : BasePathRequest<CatAllocationRequestParameters>, ICatAllocationRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatAllocationRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}

	public partial class CatAllocationDescriptor : BasePathDescriptor<CatAllocationDescriptor, CatAllocationRequestParameters>, ICatAllocationRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatAllocationRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}
}
