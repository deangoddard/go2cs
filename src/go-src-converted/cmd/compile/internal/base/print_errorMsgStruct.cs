//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:14:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using os = go.os_package;
using debug = go.runtime.debug_package;
using sort = go.sort_package;
using strings = go.strings_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class @base_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorMsg
        {
            // Constructors
            public errorMsg(NilType _)
            {
                this.pos = default;
                this.msg = default;
            }

            public errorMsg(src.XPos pos = default, @string msg = default)
            {
                this.pos = pos;
                this.msg = msg;
            }

            // Enable comparisons between nil and errorMsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorMsg value, NilType nil) => value.Equals(default(errorMsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorMsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorMsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorMsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorMsg(NilType nil) => default(errorMsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errorMsg errorMsg_cast(dynamic value)
        {
            return new errorMsg(value.pos, value.msg);
        }
    }
}}}}