//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:31 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct tflag
        {
            // Value of the tflag struct
            private readonly byte m_value;
            
            public tflag(byte value) => m_value = value;

            // Enable implicit conversions between byte and tflag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tflag(byte value) => new tflag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(tflag value) => value.m_value;
            
            // Enable comparisons between nil and tflag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tflag value, NilType nil) => value.Equals(default(tflag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tflag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tflag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tflag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tflag(NilType nil) => default(tflag);
        }
    }
}
