using System;
using Elasticsearch.Net_1_7_2;

namespace Nest_1_7_2
{
	public class SnapshotException : Exception
	{
		public IElasticsearchResponse Status { get; private set; }

		public SnapshotException(IElasticsearchResponse status, string message)
			: base(message)
		{
			Status = status;
		}
	}
}