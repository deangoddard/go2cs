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
using System.Collections;
using System.Runtime.CompilerServices;
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
        public partial struct CryptDigestBlob
        {
            // Value of the CryptDigestBlob struct
            private readonly DataBlob m_value;
            
            public CryptDigestBlob(DataBlob value) => m_value = value;

            // Enable implicit conversions between DataBlob and CryptDigestBlob struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptDigestBlob(DataBlob value) => new CryptDigestBlob(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DataBlob(CryptDigestBlob value) => value.m_value;
            
            // Enable comparisons between nil and CryptDigestBlob struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptDigestBlob value, NilType nil) => value.Equals(default(CryptDigestBlob));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptDigestBlob value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptDigestBlob value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptDigestBlob value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptDigestBlob(NilType nil) => default(CryptDigestBlob);
        }
    }
}}}}}}
