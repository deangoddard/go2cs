//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:32 UTC
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
        private partial struct mcontextt
        {
            // Constructors
            public mcontextt(NilType _)
            {
                this.__gregs = default;
                this.__fpregs = default;
                this._mc_tlsbase = default;
            }

            public mcontextt(array<uint> __gregs = default, array<byte> __fpregs = default, int _mc_tlsbase = default)
            {
                this.__gregs = __gregs;
                this.__fpregs = __fpregs;
                this._mc_tlsbase = _mc_tlsbase;
            }

            // Enable comparisons between nil and mcontextt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mcontextt value, NilType nil) => value.Equals(default(mcontextt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mcontextt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mcontextt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mcontextt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mcontextt(NilType nil) => default(mcontextt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mcontextt mcontextt_cast(dynamic value)
        {
            return new mcontextt(value.__gregs, value.__fpregs, value._mc_tlsbase);
        }
    }
}