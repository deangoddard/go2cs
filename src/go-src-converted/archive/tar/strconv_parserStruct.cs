//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct parser
        {
            // Constructors
            public parser(NilType _)
            {
                this.err = default;
            }

            public parser(error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and parser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(parser value, NilType nil) => value.Equals(default(parser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(parser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, parser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, parser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator parser(NilType nil) => default(parser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static parser parser_cast(dynamic value)
        {
            return new parser(value.err);
        }
    }
}}