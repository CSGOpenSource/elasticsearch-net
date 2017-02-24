﻿using System;
using System.Collections.Generic;
using Elasticsearch.Net_1_7_2.Connection.Thrift;
using Elasticsearch.Net_1_7_2.Connection.Thrift.Protocol;
using Nest;

namespace Profiling.Indexing
{
	public class ThriftTester : Tester
	{
		public override IElasticClient CreateClient(string indexName)
		{
			var settings = this.CreateSettings(indexName, 9500);
			settings.SetMaximumAsyncConnections(25);

		    var client = new ElasticClient(settings, new ThriftConnection(settings));
			return client;
		}
	}

    public class ThriftCompactProtocolTester : Tester
    {
        public override IElasticClient CreateClient(string indexName)
        {
            var settings = this.CreateSettings(indexName, 9500);
            settings.SetMaximumAsyncConnections(25);

            var client = new ElasticClient(settings, new ThriftConnection(settings, new TCompactProtocol.Factory()));
            return client;
        }
    }
}
