using System.Collections.Generic;

namespace Nest_1_7_2
{
	/// <summary>
	/// An analyzer of type simple that is built using a Lower Case Tokenizer.
	/// </summary>
	public class SimpleAnalyzer : AnalyzerBase
    {
		public SimpleAnalyzer()
        {
            Type = "simple";
        }
    }
}