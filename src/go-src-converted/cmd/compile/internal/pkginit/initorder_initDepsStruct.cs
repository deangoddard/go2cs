//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:27:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using heap = go.container.heap_package;
using fmt = go.fmt_package;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using staticinit = go.cmd.compile.@internal.staticinit_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class pkginit_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct initDeps
        {
            // Constructors
            public initDeps(NilType _)
            {
                this.transitive = default;
                this.seen = default;
                this.cvisit = default;
            }

            public initDeps(bool transitive = default, ir.NameSet seen = default, Action<ir.Node> cvisit = default)
            {
                this.transitive = transitive;
                this.seen = seen;
                this.cvisit = cvisit;
            }

            // Enable comparisons between nil and initDeps struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(initDeps value, NilType nil) => value.Equals(default(initDeps));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(initDeps value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, initDeps value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, initDeps value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator initDeps(NilType nil) => default(initDeps);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static initDeps initDeps_cast(dynamic value)
        {
            return new initDeps(value.transitive, value.seen, value.cvisit);
        }
    }
}}}}