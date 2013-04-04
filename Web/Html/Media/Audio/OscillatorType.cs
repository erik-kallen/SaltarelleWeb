﻿// OscillatorType.cs
// SaltarelleWeb/Html/Media/Audio
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Timothy Fries - drysart@gmail.com


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html.Media.Audio
{
    [NamedValues]
    public enum OscillatorType
    {
        [ScriptName("sine")]
        Sine,

        [ScriptName("square")]
        Square,

        [ScriptName("sawtooth")]
        Sawtooth,

        [ScriptName("triangle")]
        Triangle,

        [ScriptName("custom")]
        Custom
    }
}
