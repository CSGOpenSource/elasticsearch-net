﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest_1_7_2
{
	public interface IGetSearchTemplateResponse : IResponse
	{
		string Template { get; set; }
	}

	[JsonObject]
	public class GetSearchTemplateResponse : BaseResponse, IGetSearchTemplateResponse
	{
		[JsonProperty("template")]
		public string Template { get; set; }
	}
}
