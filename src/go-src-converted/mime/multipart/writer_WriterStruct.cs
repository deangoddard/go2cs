//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using rand = go.crypto.rand_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using textproto = go.net.textproto_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace mime
{
    public static partial class multipart_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Writer
        {
            // Constructors
            public Writer(NilType _)
            {
                this.w = default;
                this.boundary = default;
                this.lastpart = default;
            }

            public Writer(io.Writer w = default, @string boundary = default, ref ptr<part> lastpart = default)
            {
                this.w = w;
                this.boundary = boundary;
                this.lastpart = lastpart;
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
            return new Writer(value.w, value.boundary, ref value.lastpart);
        }
    }
}}