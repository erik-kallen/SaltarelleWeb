﻿namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PluginArray
	{
		internal extern PluginArray();

		[IndexerName("__Item"), FieldProperty]
		public Plugin this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public Plugin this[string name]
		{
			get;
		}

		public extern Plugin Item(int index);

		public readonly int Length;

		public extern Plugin NamedItem(string name);

		public extern void Refresh();

		public extern void Refresh(bool reloadDocuments);
	}
}
