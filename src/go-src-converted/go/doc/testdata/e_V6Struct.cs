//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace go
{
    public static partial class e_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct V6
        {
            // Constructors
            public V6(NilType _)
            {
            }
            // Enable comparisons between nil and V6 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(V6 value, NilType nil) => value.Equals(default(V6));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(V6 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, V6 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, V6 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator V6(NilType nil) => default(V6);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static V6 V6_cast(dynamic value)
        {
            return new V6();
        }
    }
}}