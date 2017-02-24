﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	[JsonObject(MemberSerialization.OptIn)]
	public class FieldDataFilter
	{
		[JsonProperty("frequency")]
		public FieldDataFrequencyFilter Frequency { get; set; }

		[JsonProperty("regex")]
		public FieldDataRegexFilter Regex { get; set; }
	}
}
