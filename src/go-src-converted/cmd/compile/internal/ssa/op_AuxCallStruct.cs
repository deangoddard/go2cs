//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:01:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.cmd.compile.@internal.abi_package;
using ir = go.cmd.compile.@internal.ir_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct AuxCall
        {
            // Constructors
            public AuxCall(NilType _)
            {
                this.Fn = default;
                this.reg = default;
                this.abiInfo = default;
            }

            public AuxCall(ref ptr<obj.LSym> Fn = default, ref ptr<regInfo> reg = default, ref ptr<abi.ABIParamResultInfo> abiInfo = default)
            {
                this.Fn = Fn;
                this.reg = reg;
                this.abiInfo = abiInfo;
            }

            // Enable comparisons between nil and AuxCall struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AuxCall value, NilType nil) => value.Equals(default(AuxCall));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AuxCall value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AuxCall value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AuxCall value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AuxCall(NilType nil) => default(AuxCall);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static AuxCall AuxCall_cast(dynamic value)
        {
            return new AuxCall(ref value.Fn, ref value.reg, ref value.abiInfo);
        }
    }
}}}}