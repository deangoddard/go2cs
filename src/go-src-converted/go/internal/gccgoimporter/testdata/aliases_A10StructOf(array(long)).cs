//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class aliases_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct A10
        {
            // Value of the A10 struct
            private readonly array<long> m_value;

            public A10(array<long> value) => m_value = value;

            // Enable implicit conversions between array<long> and A10 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A10(array<long> value) => new A10(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<long>(A10 value) => value.m_value;
            
            // Enable comparisons between nil and A10 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A10 value, NilType nil) => value.Equals(default(A10));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A10 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A10 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A10 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A10(NilType nil) => default(A10);
        }
    }
}}}
