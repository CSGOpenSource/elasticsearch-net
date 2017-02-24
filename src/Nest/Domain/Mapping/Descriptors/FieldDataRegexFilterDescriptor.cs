
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public class FieldDataRegexFilterDescriptor
	{
		internal FieldDataRegexFilter RegexFilter { get; private set; }

		public FieldDataRegexFilterDescriptor()
		{
			this.RegexFilter = new FieldDataRegexFilter();
		}

		public FieldDataRegexFilterDescriptor Pattern(string pattern)
		{
			this.RegexFilter.Pattern = pattern;
			return this;
		}
	}
}
