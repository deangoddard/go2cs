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
        public partial struct CryptIntegerBlob
        {
            // Value of the CryptIntegerBlob struct
            private readonly DataBlob m_value;
            
            public CryptIntegerBlob(DataBlob value) => m_value = value;

            // Enable implicit conversions between DataBlob and CryptIntegerBlob struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptIntegerBlob(DataBlob value) => new CryptIntegerBlob(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DataBlob(CryptIntegerBlob value) => value.m_value;
            
            // Enable comparisons between nil and CryptIntegerBlob struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptIntegerBlob value, NilType nil) => value.Equals(default(CryptIntegerBlob));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptIntegerBlob value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptIntegerBlob value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptIntegerBlob value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptIntegerBlob(NilType nil) => default(CryptIntegerBlob);
        }
    }
}}}}}}
