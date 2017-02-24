﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public abstract class TokenizerBase : IAnalysisSetting
	{
		[JsonProperty(PropertyName = "version")]
		public string Version { get; set; }
		
		[JsonProperty(PropertyName = "type")]
		public string Type { get; protected set; }
	}
}
