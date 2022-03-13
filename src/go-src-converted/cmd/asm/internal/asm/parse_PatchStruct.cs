//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:57:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using os = go.os_package;
using strconv = go.strconv_package;
using scanner = go.text.scanner_package;
using utf8 = go.unicode.utf8_package;
using arch = go.cmd.asm.@internal.arch_package;
using flags = go.cmd.asm.@internal.flags_package;
using lex = go.cmd.asm.@internal.lex_package;
using obj = go.cmd.@internal.obj_package;
using x86 = go.cmd.@internal.obj.x86_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace asm {
namespace @internal
{
    public static partial class asm_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Patch
        {
            // Constructors
            public Patch(NilType _)
            {
                this.prog = default;
                this.label = default;
            }

            public Patch(ref ptr<obj.Prog> prog = default, @string label = default)
            {
                this.prog = prog;
                this.label = label;
            }

            // Enable comparisons between nil and Patch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Patch value, NilType nil) => value.Equals(default(Patch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Patch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Patch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Patch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Patch(NilType nil) => default(Patch);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Patch Patch_cast(dynamic value)
        {
            return new Patch(ref value.prog, value.label);
        }
    }
}}}}