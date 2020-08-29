//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using trace = go.@internal.trace_package;
using log = go.log_package;
using http = go.net.http_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct countingWriter
        {
            // Constructors
            public countingWriter(NilType _)
            {
                this.size = default;
            }

            public countingWriter(long size = default)
            {
                this.size = size;
            }

            // Enable comparisons between nil and countingWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(countingWriter value, NilType nil) => value.Equals(default(countingWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(countingWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, countingWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, countingWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator countingWriter(NilType nil) => default(countingWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static countingWriter countingWriter_cast(dynamic value)
        {
            return new countingWriter(value.size);
        }
    }
}