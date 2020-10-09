//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:53 UTC
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
                this.ax = default;
                this.bx = default;
                this.cx = default;
                this.dx = default;
                this.si = default;
                this.di = default;
                this.bp = default;
                this.r8 = default;
                this.r9 = default;
                this.r10 = default;
                this.r11 = default;
                this.r12 = default;
                this.r13 = default;
                this.r14 = default;
                this.r15 = default;
                this.ds = default;
                this.es = default;
                this.fs = default;
                this.gs = default;
                this._type = default;
                this.error = default;
                this.ip = default;
                this.cs = default;
                this.flags = default;
                this.sp = default;
                this.ss = default;
            }

            public ureg(ulong ax = default, ulong bx = default, ulong cx = default, ulong dx = default, ulong si = default, ulong di = default, ulong bp = default, ulong r8 = default, ulong r9 = default, ulong r10 = default, ulong r11 = default, ulong r12 = default, ulong r13 = default, ulong r14 = default, ulong r15 = default, ushort ds = default, ushort es = default, ushort fs = default, ushort gs = default, ulong _type = default, ulong error = default, ulong ip = default, ulong cs = default, ulong flags = default, ulong sp = default, ulong ss = default)
            {
                this.ax = ax;
                this.bx = bx;
                this.cx = cx;
                this.dx = dx;
                this.si = si;
                this.di = di;
                this.bp = bp;
                this.r8 = r8;
                this.r9 = r9;
                this.r10 = r10;
                this.r11 = r11;
                this.r12 = r12;
                this.r13 = r13;
                this.r14 = r14;
                this.r15 = r15;
                this.ds = ds;
                this.es = es;
                this.fs = fs;
                this.gs = gs;
                this._type = _type;
                this.error = error;
                this.ip = ip;
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
            return new ureg(value.ax, value.bx, value.cx, value.dx, value.si, value.di, value.bp, value.r8, value.r9, value.r10, value.r11, value.r12, value.r13, value.r14, value.r15, value.ds, value.es, value.fs, value.gs, value._type, value.error, value.ip, value.cs, value.flags, value.sp, value.ss);
        }
    }
}