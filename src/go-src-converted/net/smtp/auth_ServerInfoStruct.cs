//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using hmac = go.crypto.hmac_package;
using md5 = go.crypto.md5_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace net
{
    public static partial class smtp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ServerInfo
        {
            // Constructors
            public ServerInfo(NilType _)
            {
                this.Name = default;
                this.TLS = default;
                this.Auth = default;
            }

            public ServerInfo(@string Name = default, bool TLS = default, slice<@string> Auth = default)
            {
                this.Name = Name;
                this.TLS = TLS;
                this.Auth = Auth;
            }

            // Enable comparisons between nil and ServerInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ServerInfo value, NilType nil) => value.Equals(default(ServerInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ServerInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ServerInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ServerInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ServerInfo(NilType nil) => default(ServerInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ServerInfo ServerInfo_cast(dynamic value)
        {
            return new ServerInfo(value.Name, value.TLS, value.Auth);
        }
    }
}}