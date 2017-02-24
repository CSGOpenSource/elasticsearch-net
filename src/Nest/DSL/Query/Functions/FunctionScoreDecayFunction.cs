using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class FunctionScoreDecayFunction<T> : FunctionScoreFunction<T>
		where T : class
	{
	}
}