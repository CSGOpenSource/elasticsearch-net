﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public interface IPutAliasResponse : IResponse
	{
	}

	public class PutAliasResponse : BaseResponse, IPutAliasResponse
	{
	}
}
