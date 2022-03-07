//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:09:36 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcTrigger
        {
            // Constructors
            public gcTrigger(NilType _)
            {
                this.kind = default;
                this.now = default;
                this.n = default;
            }

            public gcTrigger(gcTriggerKind kind = default, long now = default, uint n = default)
            {
                this.kind = kind;
                this.now = now;
                this.n = n;
            }

            // Enable comparisons between nil and gcTrigger struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcTrigger value, NilType nil) => value.Equals(default(gcTrigger));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcTrigger value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcTrigger value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcTrigger value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcTrigger(NilType nil) => default(gcTrigger);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gcTrigger gcTrigger_cast(dynamic value)
        {
            return new gcTrigger(value.kind, value.now, value.n);
        }
    }
}