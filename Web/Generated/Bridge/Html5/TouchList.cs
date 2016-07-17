﻿namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TouchList
	{
		internal extern TouchList();

		[IndexerName("__Item"), FieldProperty]
		public Touch this[int index]
		{
			get;
		}

		public extern Touch IdentifiedTouch(int identifier);

		public extern Touch Item(int index);

		public readonly int Length;
	}
}
