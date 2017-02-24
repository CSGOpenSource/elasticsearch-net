using System.Collections.Generic;

namespace Nest_1_7_2
{
	public interface IBulkResponse : IResponse
	{
		int Took { get; }
		bool Errors { get; }
		IEnumerable<BulkOperationResponseItem> Items { get; }
		IEnumerable<BulkOperationResponseItem> ItemsWithErrors { get; }
	}
}