//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct readOnly
        {
            // Constructors
            public readOnly(NilType _)
            {
                this.amended = default;
            }

            public readOnly(bool amended = default)
            {
                this.amended = amended;
            }

            // Enable comparisons between nil and readOnly struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readOnly value, NilType nil) => value.Equals(default(readOnly));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readOnly value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readOnly value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readOnly value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readOnly(NilType nil) => default(readOnly);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static readOnly readOnly_cast(dynamic value)
        {
            return new readOnly(value.amended);
        }
    }
}