//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct condResult
        {
            // Value of the condResult struct
            private readonly long m_value;

            public condResult(long value) => m_value = value;

            // Enable implicit conversions between long and condResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator condResult(long value) => new condResult(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(condResult value) => value.m_value;
            
            // Enable comparisons between nil and condResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(condResult value, NilType nil) => value.Equals(default(condResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(condResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, condResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, condResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator condResult(NilType nil) => default(condResult);
        }
    }
}}
