//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
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
        public partial struct A12
        {
            // Constructors
            public A12(NilType _)
            {
                this.x = default;
            }

            public A12(long x = default)
            {
                this.x = x;
            }

            // Enable comparisons between nil and A12 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A12 value, NilType nil) => value.Equals(default(A12));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A12 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A12 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A12 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A12(NilType nil) => default(A12);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static A12 A12_cast(dynamic value)
        {
            return new A12(value.x);
        }
    }
}}}