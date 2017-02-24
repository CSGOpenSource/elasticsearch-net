using System.IO;

namespace Elasticsearch.Net_1_7_2.Providers
{
	public interface IMemoryStreamProvider
	{
		MemoryStream New();
	}
}