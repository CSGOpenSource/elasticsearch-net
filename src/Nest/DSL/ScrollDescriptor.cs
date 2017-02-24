﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net_1_7_2;

namespace Nest_1_7_2
{
	public interface IScrollRequest : IRequest<ScrollRequestParameters>
	{
		string ScrollId { get; set; }
		string Scroll { get; set; }
	    Func<object, Hit<object>, Type> TypeSelector { get; set; }
	}

	internal static class ScrollPathInfo
	{
		public static void Update(
			IScrollRequest request,
			IConnectionSettingsValues settings, 
			ElasticsearchPathInfo<ScrollRequestParameters> pathInfo)
		{
			// force POST scrollId can be quite big
			pathInfo.HttpMethod = PathInfoHttpMethod.POST;
			pathInfo.ScrollId = request.ScrollId;
			// force scroll id out of RequestParameters (potentially very large)
			request.RequestParameters.RemoveQueryString("scroll_id");
			request.RequestParameters.AddQueryString("scroll", request.Scroll);
		}
	}

	public partial class ScrollRequest : BaseRequest<ScrollRequestParameters>, IScrollRequest
	{
		public string ScrollId { get; set; }
		public string Scroll { get; set; }
        public Func<object, Hit<object>, Type> TypeSelector { get; set; }

        public ScrollRequest(string scrollId, string scrollTimeout)
		{
			this.ScrollId = scrollId;
			this.Scroll = scrollTimeout;
		}

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<ScrollRequestParameters> pathInfo)
		{
			ScrollPathInfo.Update(this, settings, pathInfo);
		}
	}

	public partial class ScrollDescriptor<T> : BasePathDescriptor<ScrollDescriptor<T>, ScrollRequestParameters>, IScrollRequest,
		IHideObjectMembers
		where T : class
	{
		private IScrollRequest Self { get { return this; } }

		protected override void UpdatePathInfo(IConnectionSettingsValues settings, ElasticsearchPathInfo<ScrollRequestParameters> pathInfo)
		{
			ScrollPathInfo.Update(this, settings, pathInfo);
		}

		string IScrollRequest.ScrollId { get; set; }
		string IScrollRequest.Scroll { get; set; }
        Func<object, Hit<object>, Type> IScrollRequest.TypeSelector { get; set; }

        ///<summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        public ScrollDescriptor<T> Scroll(string scroll)
		{
			Self.Scroll = scroll;
			return this;
		}
		
		///<summary>The scroll id used to continue/start the scrolled pagination</summary>
		public ScrollDescriptor<T> ScrollId(string scrollId)
		{
			Self.ScrollId = scrollId;
			return this;
		}

        public ScrollDescriptor<T> ConcreteTypeSelector(Func<dynamic, Hit<dynamic>, Type> typeSelector)
        {
            Self.TypeSelector = typeSelector;
            return this;
        }
    }
}
