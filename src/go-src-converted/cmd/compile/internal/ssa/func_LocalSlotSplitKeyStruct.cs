//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:01:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using abi = go.cmd.compile.@internal.abi_package;
using @base = go.cmd.compile.@internal.@base_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using sha1 = go.crypto.sha1_package;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using os = go.os_package;
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
        public partial struct LocalSlotSplitKey
        {
            // Constructors
            public LocalSlotSplitKey(NilType _)
            {
                this.parent = default;
                this.Off = default;
                this.Type = default;
            }

            public LocalSlotSplitKey(ref ptr<LocalSlot> parent = default, long Off = default, ref ptr<types.Type> Type = default)
            {
                this.parent = parent;
                this.Off = Off;
                this.Type = Type;
            }

            // Enable comparisons between nil and LocalSlotSplitKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LocalSlotSplitKey value, NilType nil) => value.Equals(default(LocalSlotSplitKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LocalSlotSplitKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LocalSlotSplitKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LocalSlotSplitKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LocalSlotSplitKey(NilType nil) => default(LocalSlotSplitKey);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static LocalSlotSplitKey LocalSlotSplitKey_cast(dynamic value)
        {
            return new LocalSlotSplitKey(ref value.parent, value.Off, ref value.Type);
        }
    }
}}}}