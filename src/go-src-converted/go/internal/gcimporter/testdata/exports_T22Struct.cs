//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ast = go.go.ast_package;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct T22
        {
            // Constructors
            public T22(NilType _)
            {
                this.link = default;
            }

            public T22(ref ptr<T23> link = default)
            {
                this.link = link;
            }

            // Enable comparisons between nil and T22 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T22 value, NilType nil) => value.Equals(default(T22));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T22 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T22 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T22 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T22(NilType nil) => default(T22);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static T22 T22_cast(dynamic value)
        {
            return new T22(ref value.link);
        }
    }
}}}