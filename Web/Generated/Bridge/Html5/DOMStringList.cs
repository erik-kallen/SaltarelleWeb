﻿namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMStringList
	{
		internal extern DOMStringList();

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get;
		}

		public extern bool Contains(string @string);

		public extern string Item(int index);

		public readonly int Length;
	}
}
