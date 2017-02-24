using System;

namespace Elasticsearch.Net_1_7_2.Providers
{
	public interface IDateTimeProvider
	{
		DateTime Now();
		DateTime DeadTime(Uri uri, int attempts, int? timeoutFactor = null, int? maxDeadTimeout = null);
		DateTime AliveTime(Uri uri, int attempts);
	}
}