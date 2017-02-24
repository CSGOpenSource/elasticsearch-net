using Newtonsoft.Json;

namespace Nest_1_7_2
{
	public interface ITemplateResponse : IResponse
	{
		string Name { get; }
		TemplateMapping TemplateMapping { get; }
	}

	[JsonObject(MemberSerialization.OptIn)]
	public class TemplateResponse : BaseResponse, ITemplateResponse
	{
		public string Name { get; internal set; }
		
		public TemplateMapping TemplateMapping { get; internal set; }
	}
}
