//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:42:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;
using syntax = go.cmd.compile.@internal.syntax_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Pragma
        {
            // Constructors
            public Pragma(NilType _)
            {
                this.Flag = default;
                this.Pos = default;
            }

            public Pragma(PragmaFlag Flag = default, slice<PragmaPos> Pos = default)
            {
                this.Flag = Flag;
                this.Pos = Pos;
            }

            // Enable comparisons between nil and Pragma struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Pragma value, NilType nil) => value.Equals(default(Pragma));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Pragma value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Pragma value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Pragma value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pragma(NilType nil) => default(Pragma);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Pragma Pragma_cast(dynamic value)
        {
            return new Pragma(value.Flag, value.Pos);
        }
    }
}}}}