//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:22:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using tls = go.crypto.tls_package;
using dwarf = go.debug.dwarf_package;
using fmt = go.fmt_package;
using io = go.io_package;
using http = go.net.http_package;
using url = go.net.url_package;
using os = go.os_package;
using regexp = go.regexp_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using objfile = go.cmd.@internal.objfile_package;
using driver = go.github.com.google.pprof.driver_package;
using profile = go.github.com.google.pprof.profile_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fetcher
        {
            // Constructors
            public fetcher(NilType _)
            {
            }
            // Enable comparisons between nil and fetcher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fetcher value, NilType nil) => value.Equals(default(fetcher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fetcher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fetcher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fetcher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fetcher(NilType nil) => default(fetcher);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fetcher fetcher_cast(dynamic value)
        {
            return new fetcher();
        }
    }
}