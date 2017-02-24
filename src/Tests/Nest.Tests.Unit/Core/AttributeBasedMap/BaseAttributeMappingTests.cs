using System;
using Nest_1_7_2.Resolvers.Writers;

namespace Nest_1_7_2.Tests.Unit.Core.AttributeBasedMap
{
	public abstract class BaseAttributeMappingTests : BaseJsonTests
	{
		protected string CreateMapFor<T>() where T : class
		{
			return this.CreateMapFor(typeof(T));
		}
		protected string CreateMapFor(Type t)
		{
			var type = TypeNameMarker.Create(t);
			var writer = new TypeMappingWriter(t, type, TestElasticClient.Settings, 10);

			return writer.MapFromAttributes();
		}
	}
}
