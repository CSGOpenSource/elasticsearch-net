using Newtonsoft.Json;

namespace Nest_1_7_2
{
	/// <summary>
	/// A token filter of type nGram.
	/// </summary>
    public class NgramTokenFilter : TokenFilterBase
    {
        public NgramTokenFilter()
            : base("nGram")
        {
        }

        [JsonProperty("min_gram")]
        public int? MinGram { get; set; }

        [JsonProperty("max_gram")]
        public int? MaxGram { get; set; }
    }
}