using Newtonsoft.Json;

namespace Nest_1_7_2
{
    public interface IGetScriptResponse : IResponse
    {
        string Script { get; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class GetScriptResponse : BaseResponse, IGetScriptResponse
    {
        [JsonProperty("script")]
        public string Script { get; set; }
    }
}