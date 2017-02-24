using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject]
	public interface ISuggestContext
	{
		[JsonProperty("type")]
		string Type { get; }

		[JsonProperty("path")]
		PropertyPathMarker Path { get; set; }
	}
}
