//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using runtime = go.runtime_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using modload = go.cmd.go.@internal.modload_package;
using work = go.cmd.go.@internal.work_package;
using module = go.golang.org.x.mod.module_package;
using dirhash = go.golang.org.x.mod.sumdb.dirhash_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modcmd_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct token
        {
            // Constructors
            public token(NilType _)
            {
            }
            // Enable comparisons between nil and token struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(token value, NilType nil) => value.Equals(default(token));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(token value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, token value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, token value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator token(NilType nil) => default(token);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static token token_cast(dynamic value)
        {
            return new token();
        }
    }
}}}}