//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:11:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct puintptr
        {
            // Value of the puintptr struct
            private readonly System.UIntPtr m_value;
            
            public puintptr(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and puintptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator puintptr(System.UIntPtr value) => new puintptr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(puintptr value) => value.m_value;
            
            // Enable comparisons between nil and puintptr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(puintptr value, NilType nil) => value.Equals(default(puintptr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(puintptr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, puintptr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, puintptr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator puintptr(NilType nil) => default(puintptr);
        }
    }
}
