using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest_1_7_2
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FunctionBoostMode
	{
		[EnumMember(Value = "multiply")]
		Multiply,
		[EnumMember(Value = "replace")]
		Replace,
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "avg")]
		Average,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "min")]
		Min
	}
}