//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:02:37 UTC
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
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct stringAux
        {
            // Value of the stringAux struct
            private readonly @string m_value;
            
            public stringAux(@string value) => m_value = value;

            // Enable implicit conversions between @string and stringAux struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringAux(@string value) => new stringAux(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(stringAux value) => value.m_value;
            
            // Enable comparisons between nil and stringAux struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringAux value, NilType nil) => value.Equals(default(stringAux));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringAux value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringAux value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringAux value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringAux(NilType nil) => default(stringAux);
        }
    }
}}}}
