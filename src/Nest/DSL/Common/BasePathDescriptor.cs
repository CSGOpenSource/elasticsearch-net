using System;
using Elasticsearch.Net_1_7_2;
using Elasticsearch.Net_1_7_2.Connection.Configuration;

namespace Nest_1_7_2
{
	public abstract class BasePathDescriptor<TDescriptor, TParameters> : BaseRequest<TParameters>
		where TDescriptor : BasePathDescriptor<TDescriptor, TParameters>
		where TParameters : FluentRequestParameters<TParameters>, new()
	{
		/// <summary>
		/// Specify settings for this request alone, handy if you need a custom timeout or want to bypass sniffing, retries
		/// </summary>
		public TDescriptor RequestConfiguration(Func<RequestConfigurationDescriptor, IRequestConfiguration> configurationSelector)
		{
			configurationSelector.ThrowIfNull("configurationSelector");
			this.Request.RequestConfiguration = configurationSelector(new RequestConfigurationDescriptor());
			return (TDescriptor)this;
		}
		
		
	}
}