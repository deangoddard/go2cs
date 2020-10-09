//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CertChainPara
        {
            // Constructors
            public CertChainPara(NilType _)
            {
                this.Size = default;
                this.RequestedUsage = default;
                this.RequstedIssuancePolicy = default;
                this.URLRetrievalTimeout = default;
                this.CheckRevocationFreshnessTime = default;
                this.RevocationFreshnessTime = default;
                this.CacheResync = default;
            }

            public CertChainPara(uint Size = default, CertUsageMatch RequestedUsage = default, CertUsageMatch RequstedIssuancePolicy = default, uint URLRetrievalTimeout = default, uint CheckRevocationFreshnessTime = default, uint RevocationFreshnessTime = default, ref ptr<Filetime> CacheResync = default)
            {
                this.Size = Size;
                this.RequestedUsage = RequestedUsage;
                this.RequstedIssuancePolicy = RequstedIssuancePolicy;
                this.URLRetrievalTimeout = URLRetrievalTimeout;
                this.CheckRevocationFreshnessTime = CheckRevocationFreshnessTime;
                this.RevocationFreshnessTime = RevocationFreshnessTime;
                this.CacheResync = CacheResync;
            }

            // Enable comparisons between nil and CertChainPara struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertChainPara value, NilType nil) => value.Equals(default(CertChainPara));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertChainPara value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertChainPara value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertChainPara value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertChainPara(NilType nil) => default(CertChainPara);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertChainPara CertChainPara_cast(dynamic value)
        {
            return new CertChainPara(value.Size, value.RequestedUsage, value.RequstedIssuancePolicy, value.URLRetrievalTimeout, value.CheckRevocationFreshnessTime, value.RevocationFreshnessTime, ref value.CacheResync);
        }
    }
}}}}}}