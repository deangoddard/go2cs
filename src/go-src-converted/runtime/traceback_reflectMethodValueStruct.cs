//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytealg = go.@internal.bytealg_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct reflectMethodValue
        {
            // Constructors
            public reflectMethodValue(NilType _)
            {
                this.fn = default;
                this.stack = default;
                this.argLen = default;
            }

            public reflectMethodValue(System.UIntPtr fn = default, ref ptr<bitvector> stack = default, System.UIntPtr argLen = default)
            {
                this.fn = fn;
                this.stack = stack;
                this.argLen = argLen;
            }

            // Enable comparisons between nil and reflectMethodValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(reflectMethodValue value, NilType nil) => value.Equals(default(reflectMethodValue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(reflectMethodValue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, reflectMethodValue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, reflectMethodValue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator reflectMethodValue(NilType nil) => default(reflectMethodValue);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static reflectMethodValue reflectMethodValue_cast(dynamic value)
        {
            return new reflectMethodValue(value.fn, ref value.stack, value.argLen);
        }
    }
}