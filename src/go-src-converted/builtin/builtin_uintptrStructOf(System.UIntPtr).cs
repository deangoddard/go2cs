//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct uintptr
        {
            // Value of the uintptr struct
            private readonly System.UIntPtr m_value;
            
            public uintptr(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and uintptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uintptr(System.UIntPtr value) => new uintptr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(uintptr value) => value.m_value;
            
            // Enable comparisons between nil and uintptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uintptr value, NilType nil) => value.Equals(default(uintptr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uintptr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uintptr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uintptr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uintptr(NilType nil) => default(uintptr);
        }
    }
}
