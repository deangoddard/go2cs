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
                this.R15 = default;
                this.R14 = default;
                this.R13 = default;
                this.R12 = default;
                this.R11 = default;
                this.R10 = default;
                this.R9 = default;
                this.R8 = default;
                this.Rdi = default;
                this.Rsi = default;
                this.Rbp = default;
                this.Rbx = default;
                this.Rdx = default;
                this.Rcx = default;
                this.Rax = default;
                this.Trapno = default;
                this.Fs = default;
                this.Gs = default;
                this.Err = default;
                this.Es = default;
                this.Ds = default;
                this.Rip = default;
                this.Cs = default;
                this.Rflags = default;
                this.Rsp = default;
                this.Ss = default;
            }

            public Reg(long R15 = default, long R14 = default, long R13 = default, long R12 = default, long R11 = default, long R10 = default, long R9 = default, long R8 = default, long Rdi = default, long Rsi = default, long Rbp = default, long Rbx = default, long Rdx = default, long Rcx = default, long Rax = default, uint Trapno = default, ushort Fs = default, ushort Gs = default, uint Err = default, ushort Es = default, ushort Ds = default, long Rip = default, long Cs = default, long Rflags = default, long Rsp = default, long Ss = default)
            {
                this.R15 = R15;
                this.R14 = R14;
                this.R13 = R13;
                this.R12 = R12;
                this.R11 = R11;
                this.R10 = R10;
                this.R9 = R9;
                this.R8 = R8;
                this.Rdi = Rdi;
                this.Rsi = Rsi;
                this.Rbp = Rbp;
                this.Rbx = Rbx;
                this.Rdx = Rdx;
                this.Rcx = Rcx;
                this.Rax = Rax;
                this.Trapno = Trapno;
                this.Fs = Fs;
                this.Gs = Gs;
                this.Err = Err;
                this.Es = Es;
                this.Ds = Ds;
                this.Rip = Rip;
                this.Cs = Cs;
                this.Rflags = Rflags;
                this.Rsp = Rsp;
                this.Ss = Ss;
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
            return new Reg(value.R15, value.R14, value.R13, value.R12, value.R11, value.R10, value.R9, value.R8, value.Rdi, value.Rsi, value.Rbp, value.Rbx, value.Rdx, value.Rcx, value.Rax, value.Trapno, value.Fs, value.Gs, value.Err, value.Es, value.Ds, value.Rip, value.Cs, value.Rflags, value.Rsp, value.Ss);
        }
    }
}}}}}}