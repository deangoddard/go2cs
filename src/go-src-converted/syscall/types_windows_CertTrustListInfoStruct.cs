//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:02:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CertTrustListInfo
        {
            // Constructors
            public CertTrustListInfo(NilType _)
            {
            }
            // Enable comparisons between nil and CertTrustListInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertTrustListInfo value, NilType nil) => value.Equals(default(CertTrustListInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertTrustListInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertTrustListInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertTrustListInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertTrustListInfo(NilType nil) => default(CertTrustListInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertTrustListInfo CertTrustListInfo_cast(dynamic value)
        {
            return new CertTrustListInfo();
        }
    }
}