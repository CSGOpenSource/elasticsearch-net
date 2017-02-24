﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest_5_2_0
{
	/// <summary>
	/// Forward (default) for LTR and reverse for RTL
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IcuTransformDirection
	{
		/// <summary>LTR</summary>
		[EnumMember(Value="forward")]
		Forward,
		/// <summary> RTL</summary>
		[EnumMember(Value="reverse")]
		Reverse,
	}
}
