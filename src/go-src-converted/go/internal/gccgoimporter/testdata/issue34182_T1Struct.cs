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
    public static partial class issue34182_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T1
        {
            // Constructors
            public T1(NilType _)
            {
                this.f = default;
            }

            public T1(ref ptr<T2> f = default)
            {
                this.f = f;
            }

            // Enable comparisons between nil and T1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1 value, NilType nil) => value.Equals(default(T1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1(NilType nil) => default(T1);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T1 T1_cast(dynamic value)
        {
            return new T1(ref value.f);
        }
    }
}}}