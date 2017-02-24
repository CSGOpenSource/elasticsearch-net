using System.Collections.Generic;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{

	[JsonObject]
	[JsonConverter(typeof(WarmerMappingConverter))]
	public class WarmerMapping
	{

		public string Name { get; internal set; }

		public IEnumerable<TypeNameMarker> Types { get; internal set; }

		public ISearchRequest Source { get; internal set; }

	}
}