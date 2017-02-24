using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization.OptIn)]
	[JsonConverter(typeof(GetRepositoryResponseConverter))]
	public interface IGetRepositoryResponse : IResponse
	{
		IDictionary<string, IRepository> Repositories { get; set; }
	}

	[JsonObject]
	public class GetRepositoryResponse : BaseResponse, IGetRepositoryResponse
	{
		public GetRepositoryResponse()
		{
			this.Repositories = new Dictionary<string, IRepository>();
		}

		public IDictionary<string, IRepository> Repositories { get; set; }
	}
}
