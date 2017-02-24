﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public interface IGeoShape
	{
		[JsonProperty("type")]
		string Type { get; }
	}

	public abstract class GeoShape
	{
		public GeoShape(string type)
		{
			this.Type = type;
		}

		public string Type { get; protected set; }
	}
}
