//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using context = go.context_package;
using fmt = go.fmt_package;
using html = go.html_package;
using profile = go.@internal.profile_package;
using io = go.io_package;
using log = go.log_package;
using http = go.net.http_package;
using url = go.net.url_package;
using os = go.os_package;
using runtime = go.runtime_package;
using pprof = go.runtime.pprof_package;
using trace = go.runtime.trace_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace net {
namespace http
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct profileEntry
        {
            // Constructors
            public profileEntry(NilType _)
            {
                this.Name = default;
                this.Href = default;
                this.Desc = default;
                this.Count = default;
            }

            public profileEntry(@string Name = default, @string Href = default, @string Desc = default, nint Count = default)
            {
                this.Name = Name;
                this.Href = Href;
                this.Desc = Desc;
                this.Count = Count;
            }

            // Enable comparisons between nil and profileEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(profileEntry value, NilType nil) => value.Equals(default(profileEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(profileEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, profileEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, profileEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profileEntry(NilType nil) => default(profileEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static profileEntry profileEntry_cast(dynamic value)
        {
            return new profileEntry(value.Name, value.Href, value.Desc, value.Count);
        }
    }
}}}