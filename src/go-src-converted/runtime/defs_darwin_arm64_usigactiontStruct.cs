//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:44 UTC
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
        private partial struct usigactiont
        {
            // Constructors
            public usigactiont(NilType _)
            {
                this.__sigaction_u = default;
                this.sa_mask = default;
                this.sa_flags = default;
            }

            public usigactiont(array<byte> __sigaction_u = default, uint sa_mask = default, int sa_flags = default)
            {
                this.__sigaction_u = __sigaction_u;
                this.sa_mask = sa_mask;
                this.sa_flags = sa_flags;
            }

            // Enable comparisons between nil and usigactiont struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(usigactiont value, NilType nil) => value.Equals(default(usigactiont));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(usigactiont value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, usigactiont value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, usigactiont value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator usigactiont(NilType nil) => default(usigactiont);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static usigactiont usigactiont_cast(dynamic value)
        {
            return new usigactiont(value.__sigaction_u, value.sa_mask, value.sa_flags);
        }
    }
}