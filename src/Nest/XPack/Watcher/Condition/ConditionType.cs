﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Nest_5_2_0
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConditionType
	{
		[EnumMember(Value="always")]
		Always,
		[EnumMember(Value="never")]
		Never,
		[EnumMember(Value="script")]
		Script,
		[EnumMember(Value = "compare")]
		Compare,
		[EnumMember(Value = "array_compare")]
		ArrayCompare
	}
}
