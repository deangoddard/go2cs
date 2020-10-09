//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct heapArena
        {
            // Constructors
            public heapArena(NilType _)
            {
                this.bitmap = default;
                this.spans = default;
                this.pageInUse = default;
                this.pageMarks = default;
                this.pageSpecials = default;
                this.zeroedBase = default;
            }

            public heapArena(array<byte> bitmap = default, array<ptr<mspan>> spans = default, array<byte> pageInUse = default, array<byte> pageMarks = default, array<byte> pageSpecials = default, System.UIntPtr zeroedBase = default)
            {
                this.bitmap = bitmap;
                this.spans = spans;
                this.pageInUse = pageInUse;
                this.pageMarks = pageMarks;
                this.pageSpecials = pageSpecials;
                this.zeroedBase = zeroedBase;
            }

            // Enable comparisons between nil and heapArena struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(heapArena value, NilType nil) => value.Equals(default(heapArena));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(heapArena value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, heapArena value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, heapArena value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator heapArena(NilType nil) => default(heapArena);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static heapArena heapArena_cast(dynamic value)
        {
            return new heapArena(value.bitmap, value.spans, value.pageInUse, value.pageMarks, value.pageSpecials, value.zeroedBase);
        }
    }
}