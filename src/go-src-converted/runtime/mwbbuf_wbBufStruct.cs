//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:26:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct wbBuf
        {
            // Constructors
            public wbBuf(NilType _)
            {
                this.next = default;
                this.end = default;
                this.buf = default;
            }

            public wbBuf(System.UIntPtr next = default, System.UIntPtr end = default, array<System.UIntPtr> buf = default)
            {
                this.next = next;
                this.end = end;
                this.buf = buf;
            }

            // Enable comparisons between nil and wbBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(wbBuf value, NilType nil) => value.Equals(default(wbBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(wbBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, wbBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, wbBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator wbBuf(NilType nil) => default(wbBuf);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static wbBuf wbBuf_cast(dynamic value)
        {
            return new wbBuf(value.next, value.end, value.buf);
        }
    }
}