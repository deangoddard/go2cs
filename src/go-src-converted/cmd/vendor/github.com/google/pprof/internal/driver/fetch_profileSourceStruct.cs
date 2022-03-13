//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using http = go.net.http_package;
using url = go.net.url_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using measurement = go.github.com.google.pprof.@internal.measurement_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct profileSource
        {
            // Constructors
            public profileSource(NilType _)
            {
                this.addr = default;
                this.source = default;
                this.p = default;
                this.msrc = default;
                this.remote = default;
                this.err = default;
            }

            public profileSource(@string addr = default, ref ptr<source> source = default, ref ptr<profile.Profile> p = default, plugin.MappingSources msrc = default, bool remote = default, error err = default)
            {
                this.addr = addr;
                this.source = source;
                this.p = p;
                this.msrc = msrc;
                this.remote = remote;
                this.err = err;
            }

            // Enable comparisons between nil and profileSource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(profileSource value, NilType nil) => value.Equals(default(profileSource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(profileSource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, profileSource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, profileSource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profileSource(NilType nil) => default(profileSource);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static profileSource profileSource_cast(dynamic value)
        {
            return new profileSource(value.addr, ref value.source, ref value.p, value.msrc, value.remote, value.err);
        }
    }
}}}}}}}