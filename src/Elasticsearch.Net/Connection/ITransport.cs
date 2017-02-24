using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Elasticsearch.Net_1_7_2.Serialization;

namespace Elasticsearch.Net_1_7_2.Connection
{
	public interface ITransport
	{
		IConnectionConfigurationValues Settings { get; }
		IElasticsearchSerializer Serializer { get; }
		
		ElasticsearchResponse<T> DoRequest<T>(
			string method, 
			string path, 
			object data = null, 
			IRequestParameters requestParameters = null);

		Task<ElasticsearchResponse<T>> DoRequestAsync<T>(
			string method, 
			string path, 
			object data = null, 
			IRequestParameters requestParameters = null);
	}

}