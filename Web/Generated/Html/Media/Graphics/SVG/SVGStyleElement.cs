﻿// SVGStyleElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGStyleElement : SVGElement {
		internal SVGStyleElement() {
		}

		[IntrinsicProperty]
		public string Media {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public bool Scoped {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Title {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Xmlspace {
			get { return null; }
			set { }
		}
	}
}
