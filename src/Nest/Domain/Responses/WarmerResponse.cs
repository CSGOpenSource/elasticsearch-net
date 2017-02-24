using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nest_1_7_2
{
	public interface IWarmerResponse : IResponse
	{
		Dictionary<string, Dictionary<string, WarmerMapping>> Indices { get; }
	}

	[JsonObject]
	public class WarmerResponse : BaseResponse, IWarmerResponse
	{
		[JsonConverter(typeof(DictionaryKeysAreNotPropertyNamesJsonConverter))]
		public Dictionary<string, Dictionary<string, WarmerMapping>> Indices { get; internal set; }

	}
}
