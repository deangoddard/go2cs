//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:05 UTC
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
        public partial struct Frames
        {
            // Constructors
            public Frames(NilType _)
            {
                this.callers = default;
                this.stackExpander = default;
                this.elideWrapper = default;
            }

            public Frames(slice<System.UIntPtr> callers = default, stackExpander stackExpander = default, bool elideWrapper = default)
            {
                this.callers = callers;
                this.stackExpander = stackExpander;
                this.elideWrapper = elideWrapper;
            }

            // Enable comparisons between nil and Frames struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Frames value, NilType nil) => value.Equals(default(Frames));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Frames value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Frames value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Frames value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Frames(NilType nil) => default(Frames);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Frames Frames_cast(dynamic value)
        {
            return new Frames(value.callers, value.stackExpander, value.elideWrapper);
        }
    }
}