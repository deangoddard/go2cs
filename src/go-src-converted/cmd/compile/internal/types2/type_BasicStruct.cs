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
        public partial struct Basic
        {
            // Constructors
            public Basic(NilType _)
            {
                this.kind = default;
                this.info = default;
                this.name = default;
            }

            public Basic(BasicKind kind = default, BasicInfo info = default, @string name = default)
            {
                this.kind = kind;
                this.info = info;
                this.name = name;
            }

            // Enable comparisons between nil and Basic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Basic value, NilType nil) => value.Equals(default(Basic));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Basic value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Basic value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Basic value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Basic(NilType nil) => default(Basic);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Basic Basic_cast(dynamic value)
        {
            return new Basic(value.kind, value.info, value.name);
        }
    }
}}}}