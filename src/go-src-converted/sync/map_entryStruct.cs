//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct entry
        {
            // Constructors
            public entry(NilType _)
            {
                this.p = default;
            }

            public entry(unsafe.Pointer p = default)
            {
                this.p = p;
            }

            // Enable comparisons between nil and entry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(entry value, NilType nil) => value.Equals(default(entry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(entry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, entry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, entry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator entry(NilType nil) => default(entry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static entry entry_cast(dynamic value)
        {
            return new entry(value.p);
        }
    }
}