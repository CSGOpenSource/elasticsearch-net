using System;
using System.Collections.Generic;
using System.Linq;

namespace Nest_1_7_2
{
	[AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
	public class ElasticTypeAttribute : Attribute 
	{
		public string Name { get; set; }
		public string IdProperty { get; set; }
	}

}