//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct A
        {
            // Constructors
            public A(NilType _)
            {
                this.magic = default;
            }

            public A(long magic = default)
            {
                this.magic = magic;
            }

            // Enable comparisons between nil and A struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A value, NilType nil) => value.Equals(default(A));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A(NilType nil) => default(A);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static A A_cast(dynamic value)
        {
            return new A(value.magic);
        }
    }
}