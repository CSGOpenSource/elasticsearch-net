using System.Collections.Generic;

namespace Nest_1_7_2
{
	/// <summary>
	/// A char filter of type html_strip stripping out HTML elements from an analyzed text.
	/// </summary>
	public class HtmlStripCharFilter : CharFilterBase
	{
		public HtmlStripCharFilter()
			: base("html_strip")
		{

		}

	}

}