//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mlink
        {
            // Constructors
            public mlink(NilType _)
            {
                this.next = default;
            }

            public mlink(ref ptr<mlink> next = default)
            {
                this.next = next;
            }

            // Enable comparisons between nil and mlink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mlink value, NilType nil) => value.Equals(default(mlink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mlink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mlink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mlink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mlink(NilType nil) => default(mlink);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mlink mlink_cast(dynamic value)
        {
            return new mlink(ref value.next);
        }
    }
}