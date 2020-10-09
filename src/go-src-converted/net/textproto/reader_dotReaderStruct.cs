//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class textproto_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dotReader
        {
            // Constructors
            public dotReader(NilType _)
            {
                this.r = default;
                this.state = default;
            }

            public dotReader(ref ptr<Reader> r = default, long state = default)
            {
                this.r = r;
                this.state = state;
            }

            // Enable comparisons between nil and dotReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dotReader value, NilType nil) => value.Equals(default(dotReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dotReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dotReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dotReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dotReader(NilType nil) => default(dotReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dotReader dotReader_cast(dynamic value)
        {
            return new dotReader(ref value.r, value.state);
        }
    }
}}