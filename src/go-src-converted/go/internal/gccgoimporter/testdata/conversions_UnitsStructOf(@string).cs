//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class conversions_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Units
        {
            // Value of the Units struct
            private readonly @string m_value;
            
            public Units(@string value) => m_value = value;

            // Enable implicit conversions between @string and Units struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Units(@string value) => new Units(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(Units value) => value.m_value;
            
            // Enable comparisons between nil and Units struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Units value, NilType nil) => value.Equals(default(Units));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Units value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Units value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Units value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Units(NilType nil) => default(Units);
        }
    }
}}}
