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
        public partial struct C0
        {
            // Constructors
            public C0(NilType _)
            {
                this.f1 = default;
                this.f2 = default;
            }

            public C0(C1 f1 = default, C2 f2 = default)
            {
                this.f1 = f1;
                this.f2 = f2;
            }

            // Enable comparisons between nil and C0 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(C0 value, NilType nil) => value.Equals(default(C0));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(C0 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, C0 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, C0 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator C0(NilType nil) => default(C0);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static C0 C0_cast(dynamic value)
        {
            return new C0(value.f1, value.f2);
        }
    }
}}}