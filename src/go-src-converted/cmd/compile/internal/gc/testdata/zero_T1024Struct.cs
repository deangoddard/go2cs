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
        public partial struct T1024
        {
            // Constructors
            public T1024(NilType _)
            {
                this.pre = default;
                this.mid = default;
                this.post = default;
            }

            public T1024(array<byte> pre = default, array<byte> mid = default, array<byte> post = default)
            {
                this.pre = pre;
                this.mid = mid;
                this.post = post;
            }

            // Enable comparisons between nil and T1024 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1024 value, NilType nil) => value.Equals(default(T1024));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1024 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1024 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1024 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1024(NilType nil) => default(T1024);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T1024 T1024_cast(dynamic value)
        {
            return new T1024(value.pre, value.mid, value.post);
        }
    }
}