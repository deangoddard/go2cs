//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:23 UTC
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
using os = go.os_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using get = go.cmd.go.@internal.get_package;
using codehost = go.cmd.go.@internal.modfetch.codehost_package;
using par = go.cmd.go.@internal.par_package;
using str = go.cmd.go.@internal.str_package;
using web = go.cmd.go.@internal.web_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lookupDisabledError
        {
            // Constructors
            public lookupDisabledError(NilType _)
            {
            }
            // Enable comparisons between nil and lookupDisabledError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lookupDisabledError value, NilType nil) => value.Equals(default(lookupDisabledError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lookupDisabledError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lookupDisabledError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lookupDisabledError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lookupDisabledError(NilType nil) => default(lookupDisabledError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static lookupDisabledError lookupDisabledError_cast(dynamic value)
        {
            return new lookupDisabledError();
        }
    }
}}}}