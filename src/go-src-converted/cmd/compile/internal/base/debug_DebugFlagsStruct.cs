//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:14:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using log = go.log_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class @base_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct DebugFlags
        {
            // Constructors
            public DebugFlags(NilType _)
            {
                this.Append = default;
                this.Checkptr = default;
                this.Closure = default;
                this.DclStack = default;
                this.Defer = default;
                this.DisableNil = default;
                this.DumpPtrs = default;
                this.DwarfInl = default;
                this.Export = default;
                this.GCProg = default;
                this.InlFuncsWithClosures = default;
                this.Libfuzzer = default;
                this.LocationLists = default;
                this.Nil = default;
                this.NoOpenDefer = default;
                this.PCTab = default;
                this.Panic = default;
                this.Slice = default;
                this.SoftFloat = default;
                this.TypeAssert = default;
                this.TypecheckInl = default;
                this.WB = default;
                this.ABIWrap = default;
                this.any = default;
            }

            public DebugFlags(nint Append = default, nint Checkptr = default, nint Closure = default, nint DclStack = default, nint Defer = default, nint DisableNil = default, nint DumpPtrs = default, nint DwarfInl = default, nint Export = default, nint GCProg = default, nint InlFuncsWithClosures = default, nint Libfuzzer = default, nint LocationLists = default, nint Nil = default, nint NoOpenDefer = default, @string PCTab = default, nint Panic = default, nint Slice = default, nint SoftFloat = default, nint TypeAssert = default, nint TypecheckInl = default, nint WB = default, nint ABIWrap = default, bool any = default)
            {
                this.Append = Append;
                this.Checkptr = Checkptr;
                this.Closure = Closure;
                this.DclStack = DclStack;
                this.Defer = Defer;
                this.DisableNil = DisableNil;
                this.DumpPtrs = DumpPtrs;
                this.DwarfInl = DwarfInl;
                this.Export = Export;
                this.GCProg = GCProg;
                this.InlFuncsWithClosures = InlFuncsWithClosures;
                this.Libfuzzer = Libfuzzer;
                this.LocationLists = LocationLists;
                this.Nil = Nil;
                this.NoOpenDefer = NoOpenDefer;
                this.PCTab = PCTab;
                this.Panic = Panic;
                this.Slice = Slice;
                this.SoftFloat = SoftFloat;
                this.TypeAssert = TypeAssert;
                this.TypecheckInl = TypecheckInl;
                this.WB = WB;
                this.ABIWrap = ABIWrap;
                this.any = any;
            }

            // Enable comparisons between nil and DebugFlags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DebugFlags value, NilType nil) => value.Equals(default(DebugFlags));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DebugFlags value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DebugFlags value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DebugFlags value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DebugFlags(NilType nil) => default(DebugFlags);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DebugFlags DebugFlags_cast(dynamic value)
        {
            return new DebugFlags(value.Append, value.Checkptr, value.Closure, value.DclStack, value.Defer, value.DisableNil, value.DumpPtrs, value.DwarfInl, value.Export, value.GCProg, value.InlFuncsWithClosures, value.Libfuzzer, value.LocationLists, value.Nil, value.NoOpenDefer, value.PCTab, value.Panic, value.Slice, value.SoftFloat, value.TypeAssert, value.TypecheckInl, value.WB, value.ABIWrap, value.any);
        }
    }
}}}}