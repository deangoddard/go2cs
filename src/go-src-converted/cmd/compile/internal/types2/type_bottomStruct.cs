//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:12:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using syntax = go.cmd.compile.@internal.syntax_package;
using fmt = go.fmt_package;
using atomic = go.sync.atomic_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bottom
        {
            // Constructors
            public bottom(NilType _)
            {
            }
            // Enable comparisons between nil and bottom struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bottom value, NilType nil) => value.Equals(default(bottom));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bottom value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bottom value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bottom value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bottom(NilType nil) => default(bottom);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bottom bottom_cast(dynamic value)
        {
            return new bottom();
        }
    }
}}}}