//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:19:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct scase
        {
            // Constructors
            public scase(NilType _)
            {
                this.elem = default;
                this.c = default;
                this.pc = default;
                this.kind = default;
                this.receivedp = default;
                this.releasetime = default;
            }

            public scase(unsafe.Pointer elem = default, ref ptr<hchan> c = default, System.UIntPtr pc = default, ushort kind = default, ref ptr<bool> receivedp = default, long releasetime = default)
            {
                this.elem = elem;
                this.c = c;
                this.pc = pc;
                this.kind = kind;
                this.receivedp = receivedp;
                this.releasetime = releasetime;
            }

            // Enable comparisons between nil and scase struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(scase value, NilType nil) => value.Equals(default(scase));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(scase value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, scase value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, scase value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scase(NilType nil) => default(scase);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static scase scase_cast(dynamic value)
        {
            return new scase(value.elem, ref value.c, value.pc, value.kind, ref value.receivedp, value.releasetime);
        }
    }
}