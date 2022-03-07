//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using race = go.@internal.race_package;
using io = go.io_package;
using rand = go.math.rand_package;
using os = go.os_package;
using runtime = go.runtime_package;
using debug = go.runtime.debug_package;
using trace = go.runtime.trace_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;

#nullable enable

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct chattyPrinter
        {
            // Constructors
            public chattyPrinter(NilType _)
            {
                this.w = default;
                this.lastNameMu = default;
                this.lastName = default;
            }

            public chattyPrinter(io.Writer w = default, sync.Mutex lastNameMu = default, @string lastName = default)
            {
                this.w = w;
                this.lastNameMu = lastNameMu;
                this.lastName = lastName;
            }

            // Enable comparisons between nil and chattyPrinter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chattyPrinter value, NilType nil) => value.Equals(default(chattyPrinter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chattyPrinter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chattyPrinter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chattyPrinter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chattyPrinter(NilType nil) => default(chattyPrinter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static chattyPrinter chattyPrinter_cast(dynamic value)
        {
            return new chattyPrinter(value.w, value.lastNameMu, value.lastName);
        }
    }
}