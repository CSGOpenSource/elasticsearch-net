﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest_1_7_2
{
	[JsonConverter(typeof (StringEnumConverter))]
	public enum NoMatchShortcut
	{
		[EnumMember(Value = "none")] None,
		[EnumMember(Value = "all")] All
	}
}