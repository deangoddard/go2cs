//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using tls = go.crypto.tls_package;
using nettrace = go.@internal.nettrace_package;
using net = go.net_package;
using reflect = go.reflect_package;
using time = go.time_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httptrace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct GotConnInfo
        {
            // Constructors
            public GotConnInfo(NilType _)
            {
                this.Conn = default;
                this.Reused = default;
                this.WasIdle = default;
                this.IdleTime = default;
            }

            public GotConnInfo(net.Conn Conn = default, bool Reused = default, bool WasIdle = default, time.Duration IdleTime = default)
            {
                this.Conn = Conn;
                this.Reused = Reused;
                this.WasIdle = WasIdle;
                this.IdleTime = IdleTime;
            }

            // Enable comparisons between nil and GotConnInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(GotConnInfo value, NilType nil) => value.Equals(default(GotConnInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(GotConnInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, GotConnInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, GotConnInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator GotConnInfo(NilType nil) => default(GotConnInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static GotConnInfo GotConnInfo_cast(dynamic value)
        {
            return new GotConnInfo(value.Conn, value.Reused, value.WasIdle, value.IdleTime);
        }
    }
}}}