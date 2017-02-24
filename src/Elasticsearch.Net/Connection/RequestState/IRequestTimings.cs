using System;

namespace Elasticsearch.Net_1_7_2.Connection.RequestState
{
	public interface IRequestTimings : IDisposable
	{
		void Finish(bool success, int? httpStatusCode);
	}
}