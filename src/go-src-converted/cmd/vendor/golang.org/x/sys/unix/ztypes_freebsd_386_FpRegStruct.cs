//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FpReg
        {
            // Constructors
            public FpReg(NilType _)
            {
                this.Env = default;
                this.Acc = default;
                this.Ex_sw = default;
                this.Pad = default;
            }

            public FpReg(array<uint> Env = default, array<array<byte>> Acc = default, uint Ex_sw = default, array<byte> Pad = default)
            {
                this.Env = Env;
                this.Acc = Acc;
                this.Ex_sw = Ex_sw;
                this.Pad = Pad;
            }

            // Enable comparisons between nil and FpReg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FpReg value, NilType nil) => value.Equals(default(FpReg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FpReg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FpReg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FpReg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FpReg(NilType nil) => default(FpReg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FpReg FpReg_cast(dynamic value)
        {
            return new FpReg(value.Env, value.Acc, value.Ex_sw, value.Pad);
        }
    }
}}}}}}