//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:29 UTC
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
        public partial struct Reg
        {
            // Constructors
            public Reg(NilType _)
            {
                this.X = default;
                this.Lr = default;
                this.Sp = default;
                this.Elr = default;
                this.Spsr = default;
                this._ = default;
            }

            public Reg(array<ulong> X = default, ulong Lr = default, ulong Sp = default, ulong Elr = default, uint Spsr = default, array<byte> _ = default)
            {
                this.X = X;
                this.Lr = Lr;
                this.Sp = Sp;
                this.Elr = Elr;
                this.Spsr = Spsr;
                this._ = _;
            }

            // Enable comparisons between nil and Reg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reg value, NilType nil) => value.Equals(default(Reg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reg(NilType nil) => default(Reg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Reg Reg_cast(dynamic value)
        {
            return new Reg(value.X, value.Lr, value.Sp, value.Elr, value.Spsr, value._);
        }
    }
}}}}}}