//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using os = go.os_package;
using go;

namespace go {
namespace go
{
    public static partial class blank_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct S
        {
            // Constructors
            public S(NilType _)
            {
                this.H = default;
                this._ = default;
                this.A = default;
            }

            public S(uint H = default, byte _ = default, byte A = default)
            {
                this.H = H;
                this._ = _;
                this.A = A;
            }

            // Enable comparisons between nil and S struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(S value, NilType nil) => value.Equals(default(S));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(S value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, S value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, S value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator S(NilType nil) => default(S);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static S S_cast(dynamic value)
        {
            return new S(value.H, value._, value.A);
        }
    }
}}