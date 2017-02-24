using Elasticsearch.Net_1_7_2;
using Elasticsearch.Net_1_7_2.Connection.Configuration;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public abstract class BasePathRequest<TParameters> : BaseRequest<TParameters>
		where TParameters : IRequestParameters, new()
	{
		
		//[JsonIgnore]
		//public IRequestConfiguration RequestConfiguration
		//{	
		//	get { return base._requestConfiguration; }
		//	set { base._requestConfiguration = value; }
		//}
	}
}