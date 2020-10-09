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
        public partial struct CertTrustStatus
        {
            // Constructors
            public CertTrustStatus(NilType _)
            {
                this.ErrorStatus = default;
                this.InfoStatus = default;
            }

            public CertTrustStatus(uint ErrorStatus = default, uint InfoStatus = default)
            {
                this.ErrorStatus = ErrorStatus;
                this.InfoStatus = InfoStatus;
            }

            // Enable comparisons between nil and CertTrustStatus struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertTrustStatus value, NilType nil) => value.Equals(default(CertTrustStatus));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertTrustStatus value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertTrustStatus value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertTrustStatus value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertTrustStatus(NilType nil) => default(CertTrustStatus);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertTrustStatus CertTrustStatus_cast(dynamic value)
        {
            return new CertTrustStatus(value.ErrorStatus, value.InfoStatus);
        }
    }
}