//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:19:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct forcegcstate
        {
            // Constructors
            public forcegcstate(NilType _)
            {
                this.@lock = default;
                this.g = default;
                this.idle = default;
            }

            public forcegcstate(mutex @lock = default, ref ptr<g> g = default, uint idle = default)
            {
                this.@lock = @lock;
                this.g = g;
                this.idle = idle;
            }

            // Enable comparisons between nil and forcegcstate struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(forcegcstate value, NilType nil) => value.Equals(default(forcegcstate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(forcegcstate value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, forcegcstate value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, forcegcstate value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator forcegcstate(NilType nil) => default(forcegcstate);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static forcegcstate forcegcstate_cast(dynamic value)
        {
            return new forcegcstate(value.@lock, ref value.g, value.idle);
        }
    }
}