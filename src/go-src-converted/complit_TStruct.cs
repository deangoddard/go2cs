//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T
        {
            // Constructors
            public T(NilType _)
            {
                this.x = default;
                this.y = default;
                this.z = default;
            }

            public T(nint x = default, nint y = default, nint z = default)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            // Enable comparisons between nil and T struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T value, NilType nil) => value.Equals(default(T));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T(NilType nil) => default(T);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T T_cast(dynamic value)
        {
            return new T(value.x, value.y, value.z);
        }
    }
}