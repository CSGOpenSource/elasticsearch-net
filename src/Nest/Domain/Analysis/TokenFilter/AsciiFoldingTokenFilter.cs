﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest_1_7_2
{

	/// <summary>
	/// A token filter of type asciifolding that converts alphabetic, numeric, and symbolic Unicode characters which are 
	/// <para> not in the first 127 ASCII characters (the “Basic Latin” Unicode block) into their ASCII equivalents, if one exists.</para>
	/// </summary>
	public class AsciiFoldingTokenFilter : TokenFilterBase
	{
		public AsciiFoldingTokenFilter()
			: base("asciifolding")
		{

		}

		[JsonProperty("preserve_original")]
		public bool? PreserveOriginal { get; set; }
	}
}