//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:30 UTC
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
    public static partial class notinheap_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct S
        {
            // Constructors
            public S(NilType _)
            {
            }
            // Enable comparisons between nil and S struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S value, NilType nil) => value.Equals(default(S));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S(NilType nil) => default(S);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static S S_cast(dynamic value)
        {
            return new S();
        }
    }
}}}