using System.Security.Cryptography.X509Certificates;
using Elasticsearch.Net_1_7_2;

namespace Nest
{
	public interface IPathInfo<TParameters> 
		where TParameters : IRequestParameters, new()
	{
		ElasticsearchPathInfo<TParameters> ToPathInfo(IConnectionSettingsValues settings);
	}
}