//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:38:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CertChainElement
        {
            // Constructors
            public CertChainElement(NilType _)
            {
                this.Size = default;
                this.CertContext = default;
                this.TrustStatus = default;
                this.RevocationInfo = default;
                this.IssuanceUsage = default;
                this.ApplicationUsage = default;
                this.ExtendedErrorInfo = default;
            }

            public CertChainElement(uint Size = default, ref ptr<CertContext> CertContext = default, CertTrustStatus TrustStatus = default, ref ptr<CertRevocationInfo> RevocationInfo = default, ref ptr<CertEnhKeyUsage> IssuanceUsage = default, ref ptr<CertEnhKeyUsage> ApplicationUsage = default, ref ptr<ushort> ExtendedErrorInfo = default)
            {
                this.Size = Size;
                this.CertContext = CertContext;
                this.TrustStatus = TrustStatus;
                this.RevocationInfo = RevocationInfo;
                this.IssuanceUsage = IssuanceUsage;
                this.ApplicationUsage = ApplicationUsage;
                this.ExtendedErrorInfo = ExtendedErrorInfo;
            }

            // Enable comparisons between nil and CertChainElement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertChainElement value, NilType nil) => value.Equals(default(CertChainElement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertChainElement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertChainElement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertChainElement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertChainElement(NilType nil) => default(CertChainElement);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertChainElement CertChainElement_cast(dynamic value)
        {
            return new CertChainElement(value.Size, ref value.CertContext, value.TrustStatus, ref value.RevocationInfo, ref value.IssuanceUsage, ref value.ApplicationUsage, ref value.ExtendedErrorInfo);
        }
    }
}