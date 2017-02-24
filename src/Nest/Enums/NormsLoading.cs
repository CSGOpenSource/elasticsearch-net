using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest_1_7_2
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NormsLoading
	{
		[EnumMember(Value = "lazy")]
		Lazy,
		[EnumMember(Value = "eager")]
		Eager
	}
}
