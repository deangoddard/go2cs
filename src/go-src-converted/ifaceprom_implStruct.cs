//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:45 UTC
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
        private partial struct impl
        {
            // Constructors
            public impl(NilType _)
            {
            }
            // Enable comparisons between nil and impl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(impl value, NilType nil) => value.Equals(default(impl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(impl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, impl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, impl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator impl(NilType nil) => default(impl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static impl impl_cast(dynamic value)
        {
            return new impl();
        }
    }
}