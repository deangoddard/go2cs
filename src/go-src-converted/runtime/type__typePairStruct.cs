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
        private partial struct _typePair
        {
            // Constructors
            public _typePair(NilType _)
            {
                this.t1 = default;
                this.t2 = default;
            }

            public _typePair(ref ptr<_type> t1 = default, ref ptr<_type> t2 = default)
            {
                this.t1 = t1;
                this.t2 = t2;
            }

            // Enable comparisons between nil and _typePair struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_typePair value, NilType nil) => value.Equals(default(_typePair));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_typePair value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _typePair value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _typePair value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _typePair(NilType nil) => default(_typePair);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static _typePair _typePair_cast(dynamic value)
        {
            return new _typePair(ref value.t1, ref value.t2);
        }
    }
}