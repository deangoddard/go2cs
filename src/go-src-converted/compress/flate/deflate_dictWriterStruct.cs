//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:23:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using go;

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dictWriter
        {
            // Constructors
            public dictWriter(NilType _)
            {
                this.w = default;
            }

            public dictWriter(io.Writer w = default)
            {
                this.w = w;
            }

            // Enable comparisons between nil and dictWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dictWriter value, NilType nil) => value.Equals(default(dictWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dictWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dictWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dictWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dictWriter(NilType nil) => default(dictWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dictWriter dictWriter_cast(dynamic value)
        {
            return new dictWriter(value.w);
        }
    }
}}