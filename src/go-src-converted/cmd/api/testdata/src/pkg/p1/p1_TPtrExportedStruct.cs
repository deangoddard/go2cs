//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:20:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct TPtrExported
        {
            // Constructors
            public TPtrExported(NilType _)
            {
                this.ptr<Embedded> = default;
            }

            public TPtrExported(ref ptr<Embedded> ptr<Embedded> = default)
            {
                this.ptr<Embedded> = ptr<Embedded>;
            }

            // Enable comparisons between nil and TPtrExported struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TPtrExported value, NilType nil) => value.Equals(default(TPtrExported));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TPtrExported value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TPtrExported value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TPtrExported value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TPtrExported(NilType nil) => default(TPtrExported);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TPtrExported TPtrExported_cast(dynamic value)
        {
            return new TPtrExported(ref value.ptr<Embedded>);
        }
    }
}}}}}}