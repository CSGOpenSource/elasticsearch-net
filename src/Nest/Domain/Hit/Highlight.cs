using System.Collections.Generic;

namespace Nest_1_7_2
{
	public class Highlight
	{
		public string DocumentId { get; internal set; }
		public string Field { get; internal set; }
		public IEnumerable<string> Highlights { get; set; }
	}
}
