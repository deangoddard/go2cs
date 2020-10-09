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
        public partial struct Reg
        {
            // Constructors
            public Reg(NilType _)
            {
                this.Fs = default;
                this.Es = default;
                this.Ds = default;
                this.Edi = default;
                this.Esi = default;
                this.Ebp = default;
                this.Isp = default;
                this.Ebx = default;
                this.Edx = default;
                this.Ecx = default;
                this.Eax = default;
                this.Trapno = default;
                this.Err = default;
                this.Eip = default;
                this.Cs = default;
                this.Eflags = default;
                this.Esp = default;
                this.Ss = default;
                this.Gs = default;
            }

            public Reg(uint Fs = default, uint Es = default, uint Ds = default, uint Edi = default, uint Esi = default, uint Ebp = default, uint Isp = default, uint Ebx = default, uint Edx = default, uint Ecx = default, uint Eax = default, uint Trapno = default, uint Err = default, uint Eip = default, uint Cs = default, uint Eflags = default, uint Esp = default, uint Ss = default, uint Gs = default)
            {
                this.Fs = Fs;
                this.Es = Es;
                this.Ds = Ds;
                this.Edi = Edi;
                this.Esi = Esi;
                this.Ebp = Ebp;
                this.Isp = Isp;
                this.Ebx = Ebx;
                this.Edx = Edx;
                this.Ecx = Ecx;
                this.Eax = Eax;
                this.Trapno = Trapno;
                this.Err = Err;
                this.Eip = Eip;
                this.Cs = Cs;
                this.Eflags = Eflags;
                this.Esp = Esp;
                this.Ss = Ss;
                this.Gs = Gs;
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
            return new Reg(value.Fs, value.Es, value.Ds, value.Edi, value.Esi, value.Ebp, value.Isp, value.Ebx, value.Edx, value.Ecx, value.Eax, value.Trapno, value.Err, value.Eip, value.Cs, value.Eflags, value.Esp, value.Ss, value.Gs);
        }
    }
}}}}}}