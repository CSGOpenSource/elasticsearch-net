﻿using System;
using Elasticsearch.Net_1_7_2;

namespace Nest_1_7_2
{
	public class RestoreException : Exception
	{
		public IElasticsearchResponse Status { get; private set; }

		public RestoreException(IElasticsearchResponse status, string message = null)
			: base(message)
		{
			this.Status = status;
		}
	}
}