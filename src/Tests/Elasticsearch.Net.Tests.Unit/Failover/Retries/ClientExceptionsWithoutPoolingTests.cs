using System;
using System.IO;
using System.Threading.Tasks;
using Autofac.Extras.FakeItEasy;
using Elasticsearch.Net_1_7_2.Connection;
using Elasticsearch.Net_1_7_2.ConnectionPool;
using Elasticsearch.Net_1_7_2.Exceptions;
using Elasticsearch.Net_1_7_2.Tests.Unit.Stubs;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;

namespace Elasticsearch.Net_1_7_2.Tests.Unit.Failover.Retries
{
	/// <summary>
	/// When making calls without connectionpooling and no maxretries set 
	/// calls should NEVER be retried and original exceptions should bubble out the client
	/// WITHOUT being wrapped in a MaxRetryException
	/// </summary>
	[TestFixture]
	public class ClientExceptionsWithoutPoolingTests
	{
		private static readonly int _retries = 4;

		//we do not pass a Uri or IConnectionPool so this config
		//defaults to SingleNodeConnectionPool()
		private readonly ConnectionConfiguration _connectionConfig = new ConnectionConfiguration();

		[Test]
		public void OnConnectionException_WithoutPooling_Retires()
		{
			using (var fake = new AutoFake(callsDoNothing: true))
			{
				fake.Provide<IConnectionConfigurationValues>(_connectionConfig);
				FakeCalls.ProvideDefaultTransport(fake);

				var getCall = FakeCalls.GetSyncCall(fake);
				getCall.Throws((o)=> new Exception("inner"));

				var client = fake.Resolve<ElasticsearchClient>();

				client.Settings.MaxRetries.Should().NotHaveValue();

				var e = Assert.Throws<Exception>(() => client.Info());
				e.Message.Should().Be("inner");
				getCall.MustHaveHappened(Repeated.Exactly.Once);
			}
		}
		
		[Test]
		public void Hard_IConnectionException_AsyncCall_WithoutPooling_Retries_AndThrows()
		{
			using (var fake = new AutoFake(callsDoNothing: true))
			{
				fake.Provide<IConnectionConfigurationValues>(_connectionConfig);
				FakeCalls.ProvideDefaultTransport(fake);
				var getCall = FakeCalls.GetCall(fake);

				//return a started task that throws
				getCall.Throws((o)=> new Exception("inner"));

				var client = fake.Resolve<ElasticsearchClient>();

				client.Settings.MaxRetries.Should().NotHaveValue();

				var e = Assert.Throws<Exception>(async () => await client.InfoAsync());
				e.Message.Should().Be("inner");
				getCall.MustHaveHappened(Repeated.Exactly.Once);
			}
		}

		[Test]
		public void Soft_IConnectionException_AsyncCall_WithoutPooling_Retries_AndThrows()
		{
			using (var fake = new AutoFake(callsDoNothing: true))
			{
				fake.Provide<IConnectionConfigurationValues>(_connectionConfig);
				FakeCalls.ProvideDefaultTransport(fake);
				var getCall = FakeCalls.GetCall(fake);

				//return a started task that throws
				Func<ElasticsearchResponse<Stream>> badTask = () => { throw new Exception("inner"); };
				var t = new Task<ElasticsearchResponse<Stream>>(badTask);
				t.Start();
				getCall.Returns(t);

				var client = fake.Resolve<ElasticsearchClient>();

				client.Settings.MaxRetries.Should().NotHaveValue();

				var e = Assert.Throws<Exception>(async () => await client.InfoAsync());
				e.Message.Should().Be("inner");
				getCall.MustHaveHappened(Repeated.Exactly.Once);
			}
		}

	}
}
