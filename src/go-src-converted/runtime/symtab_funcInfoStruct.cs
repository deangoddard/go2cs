//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:05 UTC
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
        private partial struct funcInfo
        {
            // Constructors
            public funcInfo(NilType _)
            {
                this._func = default;
                this.datap = default;
            }

            public funcInfo(ref _func _func = default, ref ptr<moduledata> datap = default)
            {
                this._func = _func;
                this.datap = datap;
            }

            // Enable comparisons between nil and funcInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(funcInfo value, NilType nil) => value.Equals(default(funcInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(funcInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, funcInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, funcInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator funcInfo(NilType nil) => default(funcInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static funcInfo funcInfo_cast(dynamic value)
        {
            return new funcInfo(ref value._func, ref value.datap);
        }
    }
}