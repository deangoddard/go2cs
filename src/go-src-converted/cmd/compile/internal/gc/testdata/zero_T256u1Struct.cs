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
        public partial struct T256u1
        {
            // Constructors
            public T256u1(NilType _)
            {
                this.b = default;
                this.val = default;
            }

            public T256u1(bool b = default, array<byte> val = default)
            {
                this.b = b;
                this.val = val;
            }

            // Enable comparisons between nil and T256u1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T256u1 value, NilType nil) => value.Equals(default(T256u1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T256u1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T256u1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T256u1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T256u1(NilType nil) => default(T256u1);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T256u1 T256u1_cast(dynamic value)
        {
            return new T256u1(value.b, value.val);
        }
    }
}