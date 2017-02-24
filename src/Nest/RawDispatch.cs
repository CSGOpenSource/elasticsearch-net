﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;

namespace Nest
{
	internal partial class RawDispatch 
	{
		protected IElasticsearchClient Raw { get; set; }

		public RawDispatch(IElasticsearchClient rawElasticClient)
		{
			this.Raw = rawElasticClient;
		}
	}
}
