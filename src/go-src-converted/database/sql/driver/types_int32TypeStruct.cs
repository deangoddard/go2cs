//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:43:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct int32Type
        {
            // Constructors
            public int32Type(NilType _)
            {
            }
            // Enable comparisons between nil and int32Type struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(int32Type value, NilType nil) => value.Equals(default(int32Type));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(int32Type value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, int32Type value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, int32Type value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int32Type(NilType nil) => default(int32Type);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static int32Type int32Type_cast(dynamic value)
        {
            return new int32Type();
        }
    }
}}}