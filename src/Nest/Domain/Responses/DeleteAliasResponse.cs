using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public interface IDeleteAliasResponse : IResponse
	{
	}

	public class DeleteAliasResponse : BaseResponse, IDeleteAliasResponse
	{
	}
}
