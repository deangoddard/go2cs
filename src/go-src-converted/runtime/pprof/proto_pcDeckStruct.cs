//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using time = go.time_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pcDeck
        {
            // Constructors
            public pcDeck(NilType _)
            {
                this.pcs = default;
                this.frames = default;
                this.symbolizeResult = default;
            }

            public pcDeck(slice<System.UIntPtr> pcs = default, slice<runtime.Frame> frames = default, symbolizeFlag symbolizeResult = default)
            {
                this.pcs = pcs;
                this.frames = frames;
                this.symbolizeResult = symbolizeResult;
            }

            // Enable comparisons between nil and pcDeck struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pcDeck value, NilType nil) => value.Equals(default(pcDeck));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pcDeck value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pcDeck value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pcDeck value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pcDeck(NilType nil) => default(pcDeck);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pcDeck pcDeck_cast(dynamic value)
        {
            return new pcDeck(value.pcs, value.frames, value.symbolizeResult);
        }
    }
}}