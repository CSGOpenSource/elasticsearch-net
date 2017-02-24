using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ICatMasterRequest : IRequest<CatMasterRequestParameters>
	{
	}

	public partial class CatMasterRequest : BasePathRequest<CatMasterRequestParameters>, ICatMasterRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatMasterRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}

	public partial class CatMasterDescriptor : BasePathDescriptor<CatMasterDescriptor, CatMasterRequestParameters>, ICatMasterRequest
	{
		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<CatMasterRequestParameters> pathInfo)
		{
			CatRequestPathInfo.Update(pathInfo);
		}
	}
}
