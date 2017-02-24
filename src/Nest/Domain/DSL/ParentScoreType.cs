﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest_1_7_2
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ParentScoreType
	{
		[EnumMember(Value = "none")]
		None = 0,
		[EnumMember(Value = "score")]
		Score
	}
}
