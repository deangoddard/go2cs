//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using log = go.log_package;
using os = go.os_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pass
        {
            // Constructors
            public pass(NilType _)
            {
                this.name = default;
                this.fn = default;
                this.required = default;
                this.disabled = default;
                this.time = default;
                this.mem = default;
                this.stats = default;
                this.debug = default;
                this.test = default;
                this.dump = default;
            }

            public pass(@string name = default, Action<ref Func> fn = default, bool required = default, bool disabled = default, bool time = default, bool mem = default, long stats = default, long debug = default, long test = default, map<@string, bool> dump = default)
            {
                this.name = name;
                this.fn = fn;
                this.required = required;
                this.disabled = disabled;
                this.time = time;
                this.mem = mem;
                this.stats = stats;
                this.debug = debug;
                this.test = test;
                this.dump = dump;
            }

            // Enable comparisons between nil and pass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pass value, NilType nil) => value.Equals(default(pass));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pass value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pass value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pass value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pass(NilType nil) => default(pass);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pass pass_cast(dynamic value)
        {
            return new pass(value.name, value.fn, value.required, value.disabled, value.time, value.mem, value.stats, value.debug, value.test, value.dump);
        }
    }
}}}}