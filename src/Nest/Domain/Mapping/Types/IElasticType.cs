﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Nest_1_7_2
{
	public interface IElasticType : IFieldMapping
	{
		PropertyNameMarker Name { get; set; }
		TypeNameMarker Type { get; }
	}
}
