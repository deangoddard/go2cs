//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sigactiont
        {
            // Constructors
            public sigactiont(NilType _)
            {
                this.__sigaction_u = default;
                this.sa_tramp = default;
                this.sa_mask = default;
                this.sa_flags = default;
            }

            public sigactiont(array<byte> __sigaction_u = default, unsafe.Pointer sa_tramp = default, uint sa_mask = default, int sa_flags = default)
            {
                this.__sigaction_u = __sigaction_u;
                this.sa_tramp = sa_tramp;
                this.sa_mask = sa_mask;
                this.sa_flags = sa_flags;
            }

            // Enable comparisons between nil and sigactiont struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigactiont value, NilType nil) => value.Equals(default(sigactiont));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigactiont value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigactiont value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigactiont value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigactiont(NilType nil) => default(sigactiont);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sigactiont sigactiont_cast(dynamic value)
        {
            return new sigactiont(value.__sigaction_u, value.sa_tramp, value.sa_mask, value.sa_flags);
        }
    }
}