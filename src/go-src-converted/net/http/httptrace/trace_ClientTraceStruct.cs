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
        public partial struct ClientTrace
        {
            // Constructors
            public ClientTrace(NilType _)
            {
                this.GetConn = default;
                this.GotConn = default;
                this.PutIdleConn = default;
                this.GotFirstResponseByte = default;
                this.Got100Continue = default;
                this.DNSStart = default;
                this.DNSDone = default;
                this.ConnectStart = default;
                this.ConnectDone = default;
                this.TLSHandshakeStart = default;
                this.TLSHandshakeDone = default;
                this.WroteHeaders = default;
                this.Wait100Continue = default;
                this.WroteRequest = default;
            }

            public ClientTrace(Action<@string> GetConn = default, Action<GotConnInfo> GotConn = default, Action<error> PutIdleConn = default, Action GotFirstResponseByte = default, Action Got100Continue = default, Action<DNSStartInfo> DNSStart = default, Action<DNSDoneInfo> DNSDone = default, Action<@string, @string> ConnectStart = default, Action<@string, @string, error> ConnectDone = default, Action TLSHandshakeStart = default, Action<tls.ConnectionState, error> TLSHandshakeDone = default, Action WroteHeaders = default, Action Wait100Continue = default, Action<WroteRequestInfo> WroteRequest = default)
            {
                this.GetConn = GetConn;
                this.GotConn = GotConn;
                this.PutIdleConn = PutIdleConn;
                this.GotFirstResponseByte = GotFirstResponseByte;
                this.Got100Continue = Got100Continue;
                this.DNSStart = DNSStart;
                this.DNSDone = DNSDone;
                this.ConnectStart = ConnectStart;
                this.ConnectDone = ConnectDone;
                this.TLSHandshakeStart = TLSHandshakeStart;
                this.TLSHandshakeDone = TLSHandshakeDone;
                this.WroteHeaders = WroteHeaders;
                this.Wait100Continue = Wait100Continue;
                this.WroteRequest = WroteRequest;
            }

            // Enable comparisons between nil and ClientTrace struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ClientTrace value, NilType nil) => value.Equals(default(ClientTrace));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ClientTrace value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ClientTrace value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ClientTrace value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ClientTrace(NilType nil) => default(ClientTrace);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ClientTrace ClientTrace_cast(dynamic value)
        {
            return new ClientTrace(value.GetConn, value.GotConn, value.PutIdleConn, value.GotFirstResponseByte, value.Got100Continue, value.DNSStart, value.DNSDone, value.ConnectStart, value.ConnectDone, value.TLSHandshakeStart, value.TLSHandshakeDone, value.WroteHeaders, value.Wait100Continue, value.WroteRequest);
        }
    }
}}}