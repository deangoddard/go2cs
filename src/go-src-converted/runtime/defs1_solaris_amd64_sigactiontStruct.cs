//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

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
                this.sa_flags = default;
                this.pad_cgo_0 = default;
                this._funcptr = default;
                this.sa_mask = default;
            }

            public sigactiont(int sa_flags = default, array<byte> pad_cgo_0 = default, array<byte> _funcptr = default, sigset sa_mask = default)
            {
                this.sa_flags = sa_flags;
                this.pad_cgo_0 = pad_cgo_0;
                this._funcptr = _funcptr;
                this.sa_mask = sa_mask;
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
            return new sigactiont(value.sa_flags, value.pad_cgo_0, value._funcptr, value.sa_mask);
        }
    }
}