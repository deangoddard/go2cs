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
        private partial struct thread
        {
            // Value of the thread struct
            private readonly long m_value;
            
            public thread(long value) => m_value = value;

            // Enable implicit conversions between long and thread struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator thread(long value) => new thread(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(thread value) => value.m_value;
            
            // Enable comparisons between nil and thread struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(thread value, NilType nil) => value.Equals(default(thread));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(thread value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, thread value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, thread value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator thread(NilType nil) => default(thread);
        }
    }
}
