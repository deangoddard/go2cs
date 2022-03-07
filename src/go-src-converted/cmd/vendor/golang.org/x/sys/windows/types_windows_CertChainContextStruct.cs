//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct CertChainContext
        {
            // Constructors
            public CertChainContext(NilType _)
            {
                this.Size = default;
                this.TrustStatus = default;
                this.ChainCount = default;
                this.Chains = default;
                this.LowerQualityChainCount = default;
                this.LowerQualityChains = default;
                this.HasRevocationFreshnessTime = default;
                this.RevocationFreshnessTime = default;
            }

            public CertChainContext(uint Size = default, CertTrustStatus TrustStatus = default, uint ChainCount = default, ref ptr<ptr<CertSimpleChain>> Chains = default, uint LowerQualityChainCount = default, ref ptr<ptr<CertChainContext>> LowerQualityChains = default, uint HasRevocationFreshnessTime = default, uint RevocationFreshnessTime = default)
            {
                this.Size = Size;
                this.TrustStatus = TrustStatus;
                this.ChainCount = ChainCount;
                this.Chains = Chains;
                this.LowerQualityChainCount = LowerQualityChainCount;
                this.LowerQualityChains = LowerQualityChains;
                this.HasRevocationFreshnessTime = HasRevocationFreshnessTime;
                this.RevocationFreshnessTime = RevocationFreshnessTime;
            }

            // Enable comparisons between nil and CertChainContext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertChainContext value, NilType nil) => value.Equals(default(CertChainContext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertChainContext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertChainContext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertChainContext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertChainContext(NilType nil) => default(CertChainContext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertChainContext CertChainContext_cast(dynamic value)
        {
            return new CertChainContext(value.Size, value.TrustStatus, value.ChainCount, ref value.Chains, value.LowerQualityChainCount, ref value.LowerQualityChains, value.HasRevocationFreshnessTime, value.RevocationFreshnessTime);
        }
    }
}}}}}}