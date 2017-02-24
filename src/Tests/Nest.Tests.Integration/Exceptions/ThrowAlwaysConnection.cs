using System;
using System.IO;
using System.Threading.Tasks;
using Elasticsearch.Net_1_7_2;
using Elasticsearch.Net_1_7_2.Connection;
using Elasticsearch.Net_1_7_2.Connection.Configuration;

namespace Nest.Tests.Integration.Exceptions
{
	public class ThrowAlwaysConnection : IConnection
	{
		public TransportAddressScheme? AddressScheme { get; private set; }


		public Task<ElasticsearchResponse<Stream>> Get(Uri uri, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public ElasticsearchResponse<Stream> GetSync(Uri uri, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public Task<ElasticsearchResponse<Stream>> Head(Uri uri, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public ElasticsearchResponse<Stream> HeadSync(Uri uri, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public Task<ElasticsearchResponse<Stream>> Post(Uri uri, byte[] data, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public ElasticsearchResponse<Stream> PostSync(Uri uri, byte[] data, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public Task<ElasticsearchResponse<Stream>> Put(Uri uri, byte[] data, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public ElasticsearchResponse<Stream> PutSync(Uri uri, byte[] data, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public Task<ElasticsearchResponse<Stream>> Delete(Uri uri, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public ElasticsearchResponse<Stream> DeleteSync(Uri uri, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public Task<ElasticsearchResponse<Stream>> Delete(Uri uri, byte[] data, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}

		public ElasticsearchResponse<Stream> DeleteSync(Uri uri, byte[] data, IRequestConfiguration requestConfiguration = null)
		{
			throw new NotImplementedException();
		}
	}
}