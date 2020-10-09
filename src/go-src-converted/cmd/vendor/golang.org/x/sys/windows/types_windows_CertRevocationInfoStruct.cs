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
        public partial struct CertRevocationInfo
        {
            // Constructors
            public CertRevocationInfo(NilType _)
            {
                this.Size = default;
                this.RevocationResult = default;
                this.RevocationOid = default;
                this.OidSpecificInfo = default;
                this.HasFreshnessTime = default;
                this.FreshnessTime = default;
                this.CrlInfo = default;
            }

            public CertRevocationInfo(uint Size = default, uint RevocationResult = default, ref ptr<byte> RevocationOid = default, Pointer OidSpecificInfo = default, uint HasFreshnessTime = default, uint FreshnessTime = default, ref ptr<CertRevocationCrlInfo> CrlInfo = default)
            {
                this.Size = Size;
                this.RevocationResult = RevocationResult;
                this.RevocationOid = RevocationOid;
                this.OidSpecificInfo = OidSpecificInfo;
                this.HasFreshnessTime = HasFreshnessTime;
                this.FreshnessTime = FreshnessTime;
                this.CrlInfo = CrlInfo;
            }

            // Enable comparisons between nil and CertRevocationInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertRevocationInfo value, NilType nil) => value.Equals(default(CertRevocationInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertRevocationInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertRevocationInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertRevocationInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertRevocationInfo(NilType nil) => default(CertRevocationInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertRevocationInfo CertRevocationInfo_cast(dynamic value)
        {
            return new CertRevocationInfo(value.Size, value.RevocationResult, ref value.RevocationOid, value.OidSpecificInfo, value.HasFreshnessTime, value.FreshnessTime, ref value.CrlInfo);
        }
    }
}}}}}}