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
        public partial struct CertContext
        {
            // Constructors
            public CertContext(NilType _)
            {
                this.EncodingType = default;
                this.EncodedCert = default;
                this.Length = default;
                this.CertInfo = default;
                this.Store = default;
            }

            public CertContext(uint EncodingType = default, ref ptr<byte> EncodedCert = default, uint Length = default, ref ptr<CertInfo> CertInfo = default, Handle Store = default)
            {
                this.EncodingType = EncodingType;
                this.EncodedCert = EncodedCert;
                this.Length = Length;
                this.CertInfo = CertInfo;
                this.Store = Store;
            }

            // Enable comparisons between nil and CertContext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertContext value, NilType nil) => value.Equals(default(CertContext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertContext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertContext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertContext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertContext(NilType nil) => default(CertContext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertContext CertContext_cast(dynamic value)
        {
            return new CertContext(value.EncodingType, ref value.EncodedCert, value.Length, ref value.CertInfo, value.Store);
        }
    }
}