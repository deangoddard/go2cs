//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:43:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ptwo = go.p2_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Embedded
        {
            // Constructors
            public Embedded(NilType _)
            {
            }
            // Enable comparisons between nil and Embedded struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Embedded value, NilType nil) => value.Equals(default(Embedded));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Embedded value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Embedded value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Embedded value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Embedded(NilType nil) => default(Embedded);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Embedded Embedded_cast(dynamic value)
        {
            return new Embedded();
        }
    }
}}}}}}