﻿// MediaSource.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Html.Media.Audio;
using System.Runtime.CompilerServices;

namespace System.Media.Source {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaSource : EventTarget {
		public MediaSource() {
		}

		[IntrinsicProperty]
		public SourceBufferList ActiveSourceBuffers {
			get { return default(SourceBufferList); }
		}

		public SourceBuffer AddSourceBuffer(string type) {
			return default(SourceBuffer);
		}

		[IntrinsicProperty]
		public double Duration {
			get { return 0; }
			set { }
		}

		public void EndOfStream() {
		}

		public void EndOfStream(MediaSourceEndOfStreamError error) {
		}

		public static bool IsTypeSupported(string type) {
			return false;
		}

		[IntrinsicProperty]
		public MediaSourceReadyState ReadyState {
			get { return default(MediaSourceReadyState); }
		}

		public void RemoveSourceBuffer(SourceBuffer sourceBuffer) {
		}

		[IntrinsicProperty]
		public SourceBufferList SourceBuffers {
			get { return default(SourceBufferList); }
		}
	}
}
