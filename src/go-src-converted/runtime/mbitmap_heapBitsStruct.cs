//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:03 UTC
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
        private partial struct heapBits
        {
            // Constructors
            public heapBits(NilType _)
            {
                this.bitp = default;
                this.shift = default;
                this.arena = default;
                this.last = default;
            }

            public heapBits(ref ptr<byte> bitp = default, uint shift = default, uint arena = default, ref ptr<byte> last = default)
            {
                this.bitp = bitp;
                this.shift = shift;
                this.arena = arena;
                this.last = last;
            }

            // Enable comparisons between nil and heapBits struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(heapBits value, NilType nil) => value.Equals(default(heapBits));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(heapBits value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, heapBits value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, heapBits value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator heapBits(NilType nil) => default(heapBits);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static heapBits heapBits_cast(dynamic value)
        {
            return new heapBits(ref value.bitp, value.shift, value.arena, ref value.last);
        }
    }
}