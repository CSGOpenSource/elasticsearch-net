using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public interface IPingResponse : IResponse
	{
	}

	[JsonObject]
	public class PingResponse : BaseResponse, IPingResponse
	{
	}
}
