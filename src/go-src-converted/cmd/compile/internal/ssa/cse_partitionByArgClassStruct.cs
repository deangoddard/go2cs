//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:00:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct partitionByArgClass
        {
            // Constructors
            public partitionByArgClass(NilType _)
            {
                this.a = default;
                this.eqClass = default;
            }

            public partitionByArgClass(slice<ptr<Value>> a = default, slice<ID> eqClass = default)
            {
                this.a = a;
                this.eqClass = eqClass;
            }

            // Enable comparisons between nil and partitionByArgClass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(partitionByArgClass value, NilType nil) => value.Equals(default(partitionByArgClass));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(partitionByArgClass value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, partitionByArgClass value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, partitionByArgClass value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator partitionByArgClass(NilType nil) => default(partitionByArgClass);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static partitionByArgClass partitionByArgClass_cast(dynamic value)
        {
            return new partitionByArgClass(value.a, value.eqClass);
        }
    }
}}}}