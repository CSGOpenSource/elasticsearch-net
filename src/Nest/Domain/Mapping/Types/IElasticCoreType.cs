using System;
using System.Collections.Generic;
using System.Linq;

namespace Nest_1_7_2
{
	public interface IElasticCoreType : IElasticType
	{
		string IndexName { get; set; }
	}
}
