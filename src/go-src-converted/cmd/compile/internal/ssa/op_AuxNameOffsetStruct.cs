//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:50:18 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct AuxNameOffset
        {
            // Constructors
            public AuxNameOffset(NilType _)
            {
                this.Name = default;
                this.Offset = default;
            }

            public AuxNameOffset(ref ptr<ir.Name> Name = default, long Offset = default)
            {
                this.Name = Name;
                this.Offset = Offset;
            }

            // Enable comparisons between nil and AuxNameOffset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AuxNameOffset value, NilType nil) => value.Equals(default(AuxNameOffset));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AuxNameOffset value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AuxNameOffset value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AuxNameOffset value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AuxNameOffset(NilType nil) => default(AuxNameOffset);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static AuxNameOffset AuxNameOffset_cast(dynamic value)
        {
            return new AuxNameOffset(ref value.Name, value.Offset);
        }
    }
}}}}