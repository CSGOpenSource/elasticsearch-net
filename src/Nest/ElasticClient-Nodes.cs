﻿using Elasticsearch.Net_1_7_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nest_1_7_2
{
	using NodesHotThreadConverter = Func<IElasticsearchResponse, Stream, NodesHotThreadsResponse>;

	public partial class ElasticClient
	{
		/// <inheritdoc />
		public INodeInfoResponse NodesInfo(Func<NodesInfoDescriptor, NodesInfoDescriptor> selector = null)
		{
			selector = selector ?? (s => s);
			return this.Dispatcher.Dispatch<NodesInfoDescriptor, NodesInfoRequestParameters, NodeInfoResponse>(
				selector,
				(p, d) => this.RawDispatch.NodesInfoDispatch<NodeInfoResponse>(p)
			);
		}

		/// <inheritdoc />
		public INodeInfoResponse NodesInfo(INodesInfoRequest nodesInfoRequest)
		{
			return this.Dispatcher.Dispatch<INodesInfoRequest, NodesInfoRequestParameters, NodeInfoResponse>(
				nodesInfoRequest,
				(p, d) => this.RawDispatch.NodesInfoDispatch<NodeInfoResponse>(p)
			);
		}

		/// <inheritdoc />
		public Task<INodeInfoResponse> NodesInfoAsync(Func<NodesInfoDescriptor, NodesInfoDescriptor> selector = null)
		{
			selector = selector ?? (s => s);
			return this.Dispatcher.DispatchAsync<NodesInfoDescriptor, NodesInfoRequestParameters, NodeInfoResponse, INodeInfoResponse>(
				selector,
				(p, d) => this.RawDispatch.NodesInfoDispatchAsync<NodeInfoResponse>(p)
			);
		}

		/// <inheritdoc />
		public Task<INodeInfoResponse> NodesInfoAsync(INodesInfoRequest nodesInfoRequest)
		{
			return this.Dispatcher.DispatchAsync<INodesInfoRequest, NodesInfoRequestParameters, NodeInfoResponse, INodeInfoResponse>(
				nodesInfoRequest,
				(p, d) => this.RawDispatch.NodesInfoDispatchAsync<NodeInfoResponse>(p)
			);
		}




		/// <inheritdoc />
		public INodeStatsResponse NodesStats(Func<NodesStatsDescriptor, NodesStatsDescriptor> selector = null)
		{
			selector = selector ?? (s => s);
			return this.Dispatcher.Dispatch<NodesStatsDescriptor, NodesStatsRequestParameters, NodeStatsResponse>(
				selector,
				(p, d) => this.RawDispatch.NodesStatsDispatch<NodeStatsResponse>(p)
			);
		}

		/// <inheritdoc />
		public INodeStatsResponse NodesStats(INodesStatsRequest nodesStatsRequest)
		{
			return this.Dispatcher.Dispatch<INodesStatsRequest, NodesStatsRequestParameters, NodeStatsResponse>(
				nodesStatsRequest,
				(p, d) => this.RawDispatch.NodesStatsDispatch<NodeStatsResponse>(p)
			);
		}

		/// <inheritdoc />
		public Task<INodeStatsResponse> NodesStatsAsync(Func<NodesStatsDescriptor, NodesStatsDescriptor> selector = null)
		{
			selector = selector ?? (s => s);
			return this.Dispatcher.DispatchAsync<NodesStatsDescriptor, NodesStatsRequestParameters, NodeStatsResponse, INodeStatsResponse>(
				selector,
				(p, d) => this.RawDispatch.NodesStatsDispatchAsync<NodeStatsResponse>(p)
			);
		}

		/// <inheritdoc />
		public Task<INodeStatsResponse> NodesStatsAsync(INodesStatsRequest nodesStatsRequest)
		{
			return this.Dispatcher.DispatchAsync<INodesStatsRequest, NodesStatsRequestParameters, NodeStatsResponse, INodeStatsResponse>(
				nodesStatsRequest,
				(p, d) => this.RawDispatch.NodesStatsDispatchAsync<NodeStatsResponse>(p)
			);
		}

		/// <inheritdoc />
		public INodesHotThreadsResponse NodesHotThreads(Func<NodesHotThreadsDescriptor, NodesHotThreadsDescriptor> selector = null)
		{
			selector = selector ?? (s => s);
			return this.Dispatcher.Dispatch<NodesHotThreadsDescriptor, NodesHotThreadsRequestParameters, NodesHotThreadsResponse>(
				selector,
				(p, d) => this.RawDispatch.NodesHotThreadsDispatch<NodesHotThreadsResponse>(
					p.DeserializationState(new NodesHotThreadConverter(DeserializeNodesHotThreadResponse)))
				);
		}

		/// <inheritdoc />
		public INodesHotThreadsResponse NodesHotThreads(INodesHotThreadsRequest nodesHotThreadsRequest)
		{
			return this.Dispatcher.Dispatch<INodesHotThreadsRequest, NodesHotThreadsRequestParameters, NodesHotThreadsResponse>(
				nodesHotThreadsRequest,
				(p, d) => this.RawDispatch.NodesHotThreadsDispatch<NodesHotThreadsResponse>(
					p.DeserializationState(new NodesHotThreadConverter(DeserializeNodesHotThreadResponse)))
			);
		}

		/// <inheritdoc />
		public Task<INodesHotThreadsResponse> NodesHotThreadsAsync(Func<NodesHotThreadsDescriptor, NodesHotThreadsDescriptor> selector = null)
		{
			selector = selector ?? (s => s);
			return this.Dispatcher.DispatchAsync<NodesHotThreadsDescriptor, NodesHotThreadsRequestParameters, NodesHotThreadsResponse, INodesHotThreadsResponse>(
				selector,
				(p, d) => this.RawDispatch.NodesHotThreadsDispatchAsync<NodesHotThreadsResponse>(
					p.DeserializationState(new NodesHotThreadConverter(DeserializeNodesHotThreadResponse)))
			);
		}

		/// <inheritdoc />
		public Task<INodesHotThreadsResponse> NodesHotThreadsAsync(INodesHotThreadsRequest nodesHotThreadsRequest)
		{
			return this.Dispatcher.DispatchAsync<INodesHotThreadsRequest, NodesHotThreadsRequestParameters, NodesHotThreadsResponse, INodesHotThreadsResponse>(
				nodesHotThreadsRequest,
				(p, d) => this.RawDispatch.NodesHotThreadsDispatchAsync<NodesHotThreadsResponse>(
					p.DeserializationState(new NodesHotThreadConverter(DeserializeNodesHotThreadResponse)))
			);
		}

		/// <inheritdoc />
		public INodesShutdownResponse NodesShutdown(Func<NodesShutdownDescriptor, NodesShutdownDescriptor> nodesShutdownSelector = null)
		{
			nodesShutdownSelector = nodesShutdownSelector ?? (s => s);
			return this.Dispatcher.Dispatch<NodesShutdownDescriptor, NodesShutdownRequestParameters, NodesShutdownResponse>(
				nodesShutdownSelector,
				(p, d) => this.RawDispatch.NodesShutdownDispatch<NodesShutdownResponse>(p)
			);
		}

		/// <inheritdoc />
		public Task<INodesShutdownResponse> NodesShutdownAsync(Func<NodesShutdownDescriptor, NodesShutdownDescriptor> nodesShutdownSelector = null)
		{
			nodesShutdownSelector = nodesShutdownSelector ?? (s => s);
			return this.Dispatcher.DispatchAsync<NodesShutdownDescriptor, NodesShutdownRequestParameters, NodesShutdownResponse, INodesShutdownResponse>(
				nodesShutdownSelector,
				(p, d) => this.RawDispatch.NodesShutdownDispatchAsync<NodesShutdownResponse>(p)
			);
		}

		/// <inheritdoc />
		public INodesShutdownResponse NodesShutdown(INodesShutdownRequest nodesShutdownRequest)
		{
			return this.Dispatcher.Dispatch<INodesShutdownRequest, NodesShutdownRequestParameters, NodesShutdownResponse>(
				nodesShutdownRequest,
				(p, d) => this.RawDispatch.NodesShutdownDispatch<NodesShutdownResponse>(p)
			);
		}

		/// <inheritdoc />
		public Task<INodesShutdownResponse> NodesShutdownAsync(INodesShutdownRequest nodesShutdownRequest)
		{
			return this.Dispatcher.DispatchAsync<INodesShutdownRequest, NodesShutdownRequestParameters, NodesShutdownResponse, INodesShutdownResponse>(
				nodesShutdownRequest,
				(p, d) => this.RawDispatch.NodesShutdownDispatchAsync<NodesShutdownResponse>(p)
			);
		}

		/// <summary>
		/// Because the nodes.hot_threads endpoint returns plain text instead of JSON, we have to
		/// manually parse the response text into a typed response object.
		/// </summary>
		private NodesHotThreadsResponse DeserializeNodesHotThreadResponse(IElasticsearchResponse response, Stream stream)
		{
			var typedResponse = new NodesHotThreadsResponse();
			var plainTextResponse = Encoding.UTF8.GetString(response.ResponseRaw);

			// If the response doesn't start with :::, which is the pattern that delimits
			// each node section in the response, then the response format isn't recognized.
			// Just return an empty response object. This is especially useful when unit
			// testing against an in-memory connection where you won't get a real response.
			if (!plainTextResponse.StartsWith(":::"))
				return typedResponse;

			var sections = plainTextResponse.Split(new string[] { ":::" }, StringSplitOptions.RemoveEmptyEntries);

			foreach(var section in sections)
			{
				var sectionLines = section.Split(new string[] { "\n   \n" }, StringSplitOptions.None);

				if (sectionLines.Length > 0)
				{
					var hotThreadInfo = new HotThreadInformation
					{
						// First line contains the node name between [ ]
						Node = sectionLines.First().Split('[')[1].TrimEnd(']'),
						// The rest of the lines are hot threads
						Threads = sectionLines.Skip(1).Take(sectionLines.Length - 1).ToList()
					};

					typedResponse.HotThreads.Add(hotThreadInfo);
				}
			}

			return typedResponse;
		}
	}
}