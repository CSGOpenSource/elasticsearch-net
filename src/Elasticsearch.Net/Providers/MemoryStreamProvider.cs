using System.IO;

namespace Elasticsearch.Net_1_7_2.Providers
{
	public class MemoryStreamProvider : IMemoryStreamProvider
	{
		public MemoryStream New()
		{
			return new MemoryStream();
		}
	}
}