using System;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public class Ip4Range 
	{
		[JsonProperty(PropertyName = "mask")]
		internal string _Mask { get; set; }

		public Ip4Range Mask(string value)
		{
			this._Mask = value;
			return this;
		}
	}
}