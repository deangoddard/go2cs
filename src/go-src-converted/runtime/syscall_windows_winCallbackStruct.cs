//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:12:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.@internal.abi_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct winCallback
        {
            // Constructors
            public winCallback(NilType _)
            {
                this.fn = default;
                this.retPop = default;
                this.abiMap = default;
            }

            public winCallback(ref ptr<funcval> fn = default, System.UIntPtr retPop = default, abiDesc abiMap = default)
            {
                this.fn = fn;
                this.retPop = retPop;
                this.abiMap = abiMap;
            }

            // Enable comparisons between nil and winCallback struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(winCallback value, NilType nil) => value.Equals(default(winCallback));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(winCallback value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, winCallback value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, winCallback value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator winCallback(NilType nil) => default(winCallback);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static winCallback winCallback_cast(dynamic value)
        {
            return new winCallback(ref value.fn, value.retPop, value.abiMap);
        }
    }
}