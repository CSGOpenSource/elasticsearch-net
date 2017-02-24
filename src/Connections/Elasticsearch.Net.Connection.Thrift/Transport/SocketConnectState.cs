﻿using System.Net.Sockets;

namespace Elasticsearch.Net_1_7_2.Connection.Thrift.Transport
{
	internal class SocketConnectState
	{
		public SocketException Exception;
		public Socket Socket;

		public SocketConnectState(Socket socket)
		{
			Socket = socket;
		}
	}
}