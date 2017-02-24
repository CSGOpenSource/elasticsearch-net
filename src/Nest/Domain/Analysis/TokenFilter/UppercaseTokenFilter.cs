﻿namespace Nest_1_7_2
{
    /// <summary>
    /// A token filter of type uppercase that normalizes token text to upper case.
    /// </summary>
    public class UppercaseTokenFilter : TokenFilterBase
    {
        public UppercaseTokenFilter()
            : base("uppercase")
        {

        }

    }
}