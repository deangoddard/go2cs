//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:27:19 UTC
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
        public partial struct CertInfo
        {
            // Constructors
            public CertInfo(NilType _)
            {
            }
            // Enable comparisons between nil and CertInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CertInfo value, NilType nil) => value.Equals(default(CertInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CertInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CertInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CertInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CertInfo(NilType nil) => default(CertInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CertInfo CertInfo_cast(dynamic value)
        {
            return new CertInfo();
        }
    }
}