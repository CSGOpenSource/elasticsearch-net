using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Nest_1_7_2
{
	public interface IEmptyResponse : IResponse
	{
	}

	[JsonObject]
	public class EmptyResponse : BaseResponse, IEmptyResponse
	{
		public EmptyResponse()
		{
			this.IsValid = true;
		}
	}
}