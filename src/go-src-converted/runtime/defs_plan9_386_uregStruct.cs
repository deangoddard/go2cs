//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ureg
        {
            // Constructors
            public ureg(NilType _)
            {
                this.di = default;
                this.si = default;
                this.bp = default;
                this.nsp = default;
                this.bx = default;
                this.dx = default;
                this.cx = default;
                this.ax = default;
                this.gs = default;
                this.fs = default;
                this.es = default;
                this.ds = default;
                this.trap = default;
                this.ecode = default;
                this.pc = default;
                this.cs = default;
                this.flags = default;
                this.sp = default;
                this.ss = default;
            }

            public ureg(uint di = default, uint si = default, uint bp = default, uint nsp = default, uint bx = default, uint dx = default, uint cx = default, uint ax = default, uint gs = default, uint fs = default, uint es = default, uint ds = default, uint trap = default, uint ecode = default, uint pc = default, uint cs = default, uint flags = default, uint sp = default, uint ss = default)
            {
                this.di = di;
                this.si = si;
                this.bp = bp;
                this.nsp = nsp;
                this.bx = bx;
                this.dx = dx;
                this.cx = cx;
                this.ax = ax;
                this.gs = gs;
                this.fs = fs;
                this.es = es;
                this.ds = ds;
                this.trap = trap;
                this.ecode = ecode;
                this.pc = pc;
                this.cs = cs;
                this.flags = flags;
                this.sp = sp;
                this.ss = ss;
            }

            // Enable comparisons between nil and ureg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ureg value, NilType nil) => value.Equals(default(ureg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ureg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ureg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ureg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ureg(NilType nil) => default(ureg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ureg ureg_cast(dynamic value)
        {
            return new ureg(value.di, value.si, value.bp, value.nsp, value.bx, value.dx, value.cx, value.ax, value.gs, value.fs, value.es, value.ds, value.trap, value.ecode, value.pc, value.cs, value.flags, value.sp, value.ss);
        }
    }
}