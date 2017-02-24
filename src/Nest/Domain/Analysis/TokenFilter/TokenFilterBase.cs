using Newtonsoft.Json;

namespace Nest_1_7_2
{
    public abstract class TokenFilterBase : IAnalysisSetting
    {
        protected TokenFilterBase(string type)
        {
            this.Type = type;
        }
		
		[JsonProperty("version")]
	    public string Version { get; set; }

	    [JsonProperty("type")]
        public string Type { get; protected set; }
    }
}