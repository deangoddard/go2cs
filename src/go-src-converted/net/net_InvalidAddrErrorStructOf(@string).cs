//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:29:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct InvalidAddrError
        {
            // Value of the InvalidAddrError struct
            private readonly @string m_value;
            
            public InvalidAddrError(@string value) => m_value = value;

            // Enable implicit conversions between @string and InvalidAddrError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidAddrError(@string value) => new InvalidAddrError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(InvalidAddrError value) => value.m_value;
            
            // Enable comparisons between nil and InvalidAddrError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InvalidAddrError value, NilType nil) => value.Equals(default(InvalidAddrError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InvalidAddrError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InvalidAddrError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InvalidAddrError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidAddrError(NilType nil) => default(InvalidAddrError);
        }
    }
}
