//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:31 UTC
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
        private partial struct functype
        {
            // Constructors
            public functype(NilType _)
            {
                this.typ = default;
                this.inCount = default;
                this.outCount = default;
            }

            public functype(_type typ = default, ushort inCount = default, ushort outCount = default)
            {
                this.typ = typ;
                this.inCount = inCount;
                this.outCount = outCount;
            }

            // Enable comparisons between nil and functype struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(functype value, NilType nil) => value.Equals(default(functype));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(functype value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, functype value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, functype value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator functype(NilType nil) => default(functype);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static functype functype_cast(dynamic value)
        {
            return new functype(value.typ, value.inCount, value.outCount);
        }
    }
}