//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using reflect = go.reflect_package;
using go;

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noRows
        {
            // Constructors
            public noRows(NilType _)
            {
            }
            // Enable comparisons between nil and noRows struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noRows value, NilType nil) => value.Equals(default(noRows));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noRows value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noRows value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noRows value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noRows(NilType nil) => default(noRows);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noRows noRows_cast(dynamic value)
        {
            return new noRows();
        }
    }
}}}