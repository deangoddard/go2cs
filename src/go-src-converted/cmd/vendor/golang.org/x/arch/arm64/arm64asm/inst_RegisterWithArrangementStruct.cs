//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm64
{
    public static partial class arm64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RegisterWithArrangement
        {
            // Constructors
            public RegisterWithArrangement(NilType _)
            {
                this.r = default;
                this.a = default;
                this.cnt = default;
            }

            public RegisterWithArrangement(Reg r = default, Arrangement a = default, byte cnt = default)
            {
                this.r = r;
                this.a = a;
                this.cnt = cnt;
            }

            // Enable comparisons between nil and RegisterWithArrangement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RegisterWithArrangement value, NilType nil) => value.Equals(default(RegisterWithArrangement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RegisterWithArrangement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RegisterWithArrangement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RegisterWithArrangement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegisterWithArrangement(NilType nil) => default(RegisterWithArrangement);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RegisterWithArrangement RegisterWithArrangement_cast(dynamic value)
        {
            return new RegisterWithArrangement(value.r, value.a, value.cnt);
        }
    }
}}}}}}}