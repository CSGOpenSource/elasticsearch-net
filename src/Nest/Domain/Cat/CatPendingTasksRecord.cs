using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonObject]
	public class CatPendingTasksRecord : ICatRecord
	{
		[JsonProperty("insertOrder")]
		public int? InsertOrder { get; set; }

		[JsonProperty("timeInQueue")]
		public string TimeInQueue { get; set; }

		[JsonProperty("priority")]
		public string Priority { get; set; }

		[JsonProperty("source")]
		public string Source { get; set; }

	}
}