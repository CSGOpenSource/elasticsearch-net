using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest_1_7_2
{
    [JsonConverter(typeof (StringEnumConverter))]
    public enum ScriptLang
    {
        [EnumMember(Value = "groovy")]
        Groovy,
        [EnumMember(Value = "js")]
        JS,
        [EnumMember(Value = "expression")]
        Expression,
        [EnumMember(Value = "python")]
        Python,
        [EnumMember(Value = "native")]
        Native,
    }
}