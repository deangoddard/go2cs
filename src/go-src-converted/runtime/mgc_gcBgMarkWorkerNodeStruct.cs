//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct gcBgMarkWorkerNode
        {
            // Constructors
            public gcBgMarkWorkerNode(NilType _)
            {
                this.node = default;
                this.gp = default;
                this.m = default;
            }

            public gcBgMarkWorkerNode(lfnode node = default, guintptr gp = default, muintptr m = default)
            {
                this.node = node;
                this.gp = gp;
                this.m = m;
            }

            // Enable comparisons between nil and gcBgMarkWorkerNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcBgMarkWorkerNode value, NilType nil) => value.Equals(default(gcBgMarkWorkerNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcBgMarkWorkerNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcBgMarkWorkerNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcBgMarkWorkerNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcBgMarkWorkerNode(NilType nil) => default(gcBgMarkWorkerNode);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static gcBgMarkWorkerNode gcBgMarkWorkerNode_cast(dynamic value)
        {
            return new gcBgMarkWorkerNode(value.node, value.gp, value.m);
        }
    }
}