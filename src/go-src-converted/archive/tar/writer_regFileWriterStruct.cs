//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
using path = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct regFileWriter
        {
            // Constructors
            public regFileWriter(NilType _)
            {
                this.w = default;
                this.nb = default;
            }

            public regFileWriter(io.Writer w = default, long nb = default)
            {
                this.w = w;
                this.nb = nb;
            }

            // Enable comparisons between nil and regFileWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(regFileWriter value, NilType nil) => value.Equals(default(regFileWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(regFileWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, regFileWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, regFileWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator regFileWriter(NilType nil) => default(regFileWriter);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static regFileWriter regFileWriter_cast(dynamic value)
        {
            return new regFileWriter(value.w, value.nb);
        }
    }
}}