//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.@internal.abi_package;
using itoa = go.@internal.itoa_package;
using unsafeheader = go.@internal.unsafeheader_package;
using math = go.math_package;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ValueError
        {
            // Constructors
            public ValueError(NilType _)
            {
                this.Method = default;
                this.Kind = default;
            }

            public ValueError(@string Method = default, Kind Kind = default)
            {
                this.Method = Method;
                this.Kind = Kind;
            }

            // Enable comparisons between nil and ValueError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ValueError value, NilType nil) => value.Equals(default(ValueError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ValueError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ValueError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ValueError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ValueError(NilType nil) => default(ValueError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ValueError ValueError_cast(dynamic value)
        {
            return new ValueError(value.Method, value.Kind);
        }
    }
}