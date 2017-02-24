
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nest_1_7_2
{
	[JsonConverter(typeof(SimilaritySettingsConverter))]
	public class SimilaritySettings
	{
		public SimilaritySettings()
		{
			this.CustomSimilarities = new Dictionary<string, SimilarityBase>();
		}

		public string Default { get; set; }

		[JsonConverter(typeof(SimilarityCollectionConverter))]
		public IDictionary<string, SimilarityBase> CustomSimilarities { get; set; }
	}
}
