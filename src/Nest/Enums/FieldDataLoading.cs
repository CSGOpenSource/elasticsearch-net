﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Nest_1_7_2
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FieldDataLoading
	{
		[EnumMember(Value = "eager")]
		Eager,
		[EnumMember(Value = "eager_global_ordinals")]
		EagerGlobalOrdinals
	}
}
