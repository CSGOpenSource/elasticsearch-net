using Elasticsearch.Net_1_7_2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public interface ICatResponse<TCatRectord> : IResponse
		where TCatRectord : ICatRecord
	{
		IEnumerable<TCatRectord> Records { get; }
	}

	[JsonObject]
	public class CatResponse<TCatRecord> : BaseResponse, ICatResponse<TCatRecord>
		where TCatRecord : ICatRecord
	{
		public IEnumerable<TCatRecord> Records { get; internal set; }
	}
}
