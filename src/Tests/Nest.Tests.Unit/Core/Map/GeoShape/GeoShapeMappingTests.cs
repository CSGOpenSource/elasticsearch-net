using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Elasticsearch.Net_1_7_2;
using FluentAssertions;
using Nest_1_7_2.Resolvers;
using Nest_1_7_2.Tests.MockData.Domain;
using NUnit.Framework;

namespace Nest_1_7_2.Tests.Unit.Core.Map.GeoShape
{
	[TestFixture]
	public class GeoShapeMappingTests : BaseJsonTests
	{

		[Test]
		public void PrecisionSerializesAsString()
		{
			var result = this._client.Map<ElasticsearchProject>(m => m
				.Properties(props => props
					.GeoShape(s => s
						.Name(p => p.MyGeoShape)
						.Precision(1.2, GeoPrecisionUnit.Centimeters)
						.DistanceErrorPercentage(0.025)
					)
				)
			);
			this.JsonEquals(result.ConnectionStatus.Request, MethodInfo.GetCurrentMethod());
		}

		[Test]
		public void PrecisionSurvivesDeserialize()
		{
			var mapping = new GeoShapeMapping()
			{
				Name = Property.Name<ElasticsearchProject>(p => p.MyGeoShape),
				Precision = new GeoPrecision(3.4, GeoPrecisionUnit.Yard)
			};
			var serialized = this._client.Serializer.Serialize(mapping);
			var deserialized = this._client.Serializer.Deserialize<GeoShapeMapping>(new MemoryStream(serialized));
			deserialized.Should().NotBeNull();
			deserialized.Precision.Should().NotBeNull();
			deserialized.Precision.Precision.Should().Be(3.4);
			deserialized.Precision.Unit.Should().Be(GeoPrecisionUnit.Yard);

		}
	}
}
