﻿namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceComponentStats : RTCStats
	{
		public bool ActiveConnection;

		public int BytesReceived;

		public int BytesSent;

		public int Component;

		public string TransportId;
	}
}
