//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:04:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flag = go.flag_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using exec = go.os.exec_package;
using test2json = go.cmd.@internal.test2json_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct countWriter
        {
            // Constructors
            public countWriter(NilType _)
            {
                this.n = default;
                this.w = default;
            }

            public countWriter(long n = default, io.Writer w = default)
            {
                this.n = n;
                this.w = w;
            }

            // Enable comparisons between nil and countWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(countWriter value, NilType nil) => value.Equals(default(countWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(countWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, countWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, countWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator countWriter(NilType nil) => default(countWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static countWriter countWriter_cast(dynamic value)
        {
            return new countWriter(value.n, value.w);
        }
    }
}