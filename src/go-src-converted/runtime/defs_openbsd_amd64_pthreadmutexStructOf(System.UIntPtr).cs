//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:34 UTC
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
        private partial struct pthreadmutex
        {
            // Value of the pthreadmutex struct
            private readonly System.UIntPtr m_value;
            
            public pthreadmutex(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and pthreadmutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthreadmutex(System.UIntPtr value) => new pthreadmutex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(pthreadmutex value) => value.m_value;
            
            // Enable comparisons between nil and pthreadmutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pthreadmutex value, NilType nil) => value.Equals(default(pthreadmutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pthreadmutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pthreadmutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pthreadmutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pthreadmutex(NilType nil) => default(pthreadmutex);
        }
    }
}
