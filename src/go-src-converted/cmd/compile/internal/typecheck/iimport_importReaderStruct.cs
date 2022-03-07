//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:48:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using io = go.io_package;
using big = go.math.big_package;
using os = go.os_package;
using strings = go.strings_package;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using types = go.cmd.compile.@internal.types_package;
using bio = go.cmd.@internal.bio_package;
using goobj = go.cmd.@internal.goobj_package;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class typecheck_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(strings.Reader))]
        private partial struct importReader
        {
            // Reader structure promotion - sourced from value copy
            private readonly ptr<Reader> m_ReaderRef;

            private ref Reader Reader_val => ref m_ReaderRef.Value;

            public ref @string s => ref m_ReaderRef.Value.s;

            public ref long i => ref m_ReaderRef.Value.i;

            public ref nint prevRune => ref m_ReaderRef.Value.prevRune;

            // Constructors
            public importReader(NilType _)
            {
                this.m_ReaderRef = new ptr<strings.Reader>(new strings.Reader(nil));
                this.p = default;
                this.currPkg = default;
                this.prevBase = default;
                this.prevLine = default;
                this.prevColumn = default;
                this.curfn = default;
                this.allDcls = default;
                this.allClosureVars = default;
            }

            public importReader(strings.Reader Reader = default, ref ptr<iimporter> p = default, ref ptr<types.Pkg> currPkg = default, ref ptr<src.PosBase> prevBase = default, long prevLine = default, long prevColumn = default, ref ptr<ir.Func> curfn = default, slice<ptr<ir.Name>> allDcls = default, slice<ptr<ir.Name>> allClosureVars = default)
            {
                this.m_ReaderRef = new ptr<strings.Reader>(Reader);
                this.p = p;
                this.currPkg = currPkg;
                this.prevBase = prevBase;
                this.prevLine = prevLine;
                this.prevColumn = prevColumn;
                this.curfn = curfn;
                this.allDcls = allDcls;
                this.allClosureVars = allClosureVars;
            }

            // Enable comparisons between nil and importReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(importReader value, NilType nil) => value.Equals(default(importReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(importReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, importReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, importReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator importReader(NilType nil) => default(importReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static importReader importReader_cast(dynamic value)
        {
            return new importReader(value.Reader, ref value.p, ref value.currPkg, ref value.prevBase, value.prevLine, value.prevColumn, ref value.curfn, value.allDcls, value.allClosureVars);
        }
    }
}}}}