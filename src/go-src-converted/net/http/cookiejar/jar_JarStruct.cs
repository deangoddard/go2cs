//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using net = go.net_package;
using http = go.net.http_package;
using ascii = go.net.http.@internal.ascii_package;
using url = go.net.url_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace net {
namespace http
{
    public static partial class cookiejar_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Jar
        {
            // Constructors
            public Jar(NilType _)
            {
                this.psList = default;
                this.mu = default;
                this.entries = default;
                this.nextSeqNum = default;
            }

            public Jar(PublicSuffixList psList = default, sync.Mutex mu = default, map<@string, map<@string, entry>> entries = default, ulong nextSeqNum = default)
            {
                this.psList = psList;
                this.mu = mu;
                this.entries = entries;
                this.nextSeqNum = nextSeqNum;
            }

            // Enable comparisons between nil and Jar struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Jar value, NilType nil) => value.Equals(default(Jar));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Jar value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Jar value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Jar value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Jar(NilType nil) => default(Jar);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Jar Jar_cast(dynamic value)
        {
            return new Jar(value.psList, value.mu, value.entries, value.nextSeqNum);
        }
    }
}}}