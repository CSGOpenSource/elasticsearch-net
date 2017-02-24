using System;
using System.Collections.Generic;
using System.Linq;
using Nest_1_7_2.Resolvers.Converters;
using Newtonsoft.Json;

namespace Nest_1_7_2
{
	[JsonConverter(typeof(ReadAsTypeConverter<TypeFilterDescriptor>))]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ITypeFilter : IFilter
	{
		[JsonProperty(PropertyName = "value")]
		TypeNameMarker Value { get; set; }
	}

	public class TypeFilter : PlainFilter, ITypeFilter
	{
		protected internal override void WrapInContainer(IFilterContainer container)
		{
			container.Type = this;
		}

		public TypeNameMarker Value { get; set; }
	}

	public class TypeFilterDescriptor : FilterBase, ITypeFilter
	{
		bool IFilter.IsConditionless
		{
			get
			{
				return ((ITypeFilter)this).Value.IsConditionless();
			}

		}

		[JsonProperty(PropertyName = "value")]
		TypeNameMarker ITypeFilter.Value { get; set; }
	}
}
