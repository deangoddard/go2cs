//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:23 UTC
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
        private partial struct mSpanList
        {
            // Constructors
            public mSpanList(NilType _)
            {
                this.first = default;
                this.last = default;
            }

            public mSpanList(ref ptr<mspan> first = default, ref ptr<mspan> last = default)
            {
                this.first = first;
                this.last = last;
            }

            // Enable comparisons between nil and mSpanList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mSpanList value, NilType nil) => value.Equals(default(mSpanList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mSpanList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mSpanList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mSpanList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mSpanList(NilType nil) => default(mSpanList);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mSpanList mSpanList_cast(dynamic value)
        {
            return new mSpanList(ref value.first, ref value.last);
        }
    }
}