//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using math = go.runtime.@internal.math_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct notInHeapSlice
        {
            // Constructors
            public notInHeapSlice(NilType _)
            {
                this.array = default;
                this.len = default;
                this.cap = default;
            }

            public notInHeapSlice(ref ptr<notInHeap> array = default, nint len = default, nint cap = default)
            {
                this.array = array;
                this.len = len;
                this.cap = cap;
            }

            // Enable comparisons between nil and notInHeapSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(notInHeapSlice value, NilType nil) => value.Equals(default(notInHeapSlice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(notInHeapSlice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, notInHeapSlice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, notInHeapSlice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator notInHeapSlice(NilType nil) => default(notInHeapSlice);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static notInHeapSlice notInHeapSlice_cast(dynamic value)
        {
            return new notInHeapSlice(ref value.array, value.len, value.cap);
        }
    }
}