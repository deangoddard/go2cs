//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:47 UTC
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
        private partial struct stringInterfacePtr
        {
            // Value of the stringInterfacePtr struct
            private readonly @string m_value;
            
            public stringInterfacePtr(@string value) => m_value = value;

            // Enable implicit conversions between @string and stringInterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringInterfacePtr(@string value) => new stringInterfacePtr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(stringInterfacePtr value) => value.m_value;
            
            // Enable comparisons between nil and stringInterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringInterfacePtr value, NilType nil) => value.Equals(default(stringInterfacePtr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringInterfacePtr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringInterfacePtr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringInterfacePtr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringInterfacePtr(NilType nil) => default(stringInterfacePtr);
        }
    }
}
