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
        public partial struct CertPoliciesInfo
        {
            // Constructors
            public CertPoliciesInfo(NilType _)
            {
                this.Count = default;
                this.PolicyInfos = default;
            }

            public CertPoliciesInfo(uint Count = default, ref ptr<CertPolicyInfo> PolicyInfos = default)
            {
                this.Count = Count;
                this.PolicyInfos = PolicyInfos;
            }

            // Enable comparisons between nil and CertPoliciesInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertPoliciesInfo value, NilType nil) => value.Equals(default(CertPoliciesInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertPoliciesInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertPoliciesInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertPoliciesInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertPoliciesInfo(NilType nil) => default(CertPoliciesInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertPoliciesInfo CertPoliciesInfo_cast(dynamic value)
        {
            return new CertPoliciesInfo(value.Count, ref value.PolicyInfos);
        }
    }
}}}}}}