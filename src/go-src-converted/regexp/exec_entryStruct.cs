//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using syntax = go.regexp.syntax_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct entry
        {
            // Constructors
            public entry(NilType _)
            {
                this.pc = default;
                this.t = default;
            }

            public entry(uint pc = default, ref ptr<thread> t = default)
            {
                this.pc = pc;
                this.t = t;
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

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static entry entry_cast(dynamic value)
        {
            return new entry(value.pc, ref value.t);
        }
    }
}