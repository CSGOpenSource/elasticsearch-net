﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	//	[JsonConverter(typeof(TemplateMappingConverter))]
	//	[JsonObject(MemberSerialization.OptIn)]
	public class TemplateMapping
	{
		public TemplateMapping()
		{
		}

		[JsonProperty("template")]
		public string Template { get; set; }

		[JsonProperty("order")]
		public int? Order { get; set; }

		[JsonProperty("settings")]
		[JsonConverter(typeof(DictionaryKeysAreNotPropertyNamesJsonConverter))]
		public FluentDictionary<string, object> Settings { get; set; }

		[JsonProperty("mappings")]
		[JsonConverter(typeof(DictionaryKeysAreNotPropertyNamesJsonConverter))]
		public Dictionary<string, RootObjectMapping> Mappings { get; set; }

		[JsonProperty("warmers")]
		[JsonConverter(typeof(DictionaryKeysAreNotPropertyNamesJsonConverter))]
		public Dictionary<string, WarmerMapping> Warmers { get; set; }
		
		[JsonProperty("aliases")]
		[JsonConverter(typeof(DictionaryKeysAreNotPropertyNamesJsonConverter))]
		public Dictionary<string, ICreateAliasOperation> Aliases { get; set; }
	}
}