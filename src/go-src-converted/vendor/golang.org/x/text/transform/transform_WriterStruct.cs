//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:07:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text
{
    public static partial class transform_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Writer
        {
            // Constructors
            public Writer(NilType _)
            {
                this.w = default;
                this.t = default;
                this.dst = default;
                this.src = default;
                this.n = default;
            }

            public Writer(io.Writer w = default, Transformer t = default, slice<byte> dst = default, slice<byte> src = default, long n = default)
            {
                this.w = w;
                this.t = t;
                this.dst = dst;
                this.src = src;
                this.n = n;
            }

            // Enable comparisons between nil and Writer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer value, NilType nil) => value.Equals(default(Writer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Writer(NilType nil) => default(Writer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Writer Writer_cast(dynamic value)
        {
            return new Writer(value.w, value.t, value.dst, value.src, value.n);
        }
    }
}}}}}