//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:58:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T24u2
        {
            // Constructors
            public T24u2(NilType _)
            {
                this.i = default;
                this.val = default;
            }

            public T24u2(ushort i = default, array<byte> val = default)
            {
                this.i = i;
                this.val = val;
            }

            // Enable comparisons between nil and T24u2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T24u2 value, NilType nil) => value.Equals(default(T24u2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T24u2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T24u2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T24u2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T24u2(NilType nil) => default(T24u2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T24u2 T24u2_cast(dynamic value)
        {
            return new T24u2(value.i, value.val);
        }
    }
}