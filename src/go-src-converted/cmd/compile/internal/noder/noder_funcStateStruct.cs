//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:14:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @base = go.cmd.compile.@internal.@base_package;
using dwarfgen = go.cmd.compile.@internal.dwarfgen_package;
using ir = go.cmd.compile.@internal.ir_package;
using syntax = go.cmd.compile.@internal.syntax_package;
using typecheck = go.cmd.compile.@internal.typecheck_package;
using types = go.cmd.compile.@internal.types_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class noder_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct funcState
        {
            // Constructors
            public funcState(NilType _)
            {
                this.scopeVars = default;
                this.marker = default;
                this.lastCloseScopePos = default;
            }

            public funcState(slice<nint> scopeVars = default, dwarfgen.ScopeMarker marker = default, syntax.Pos lastCloseScopePos = default)
            {
                this.scopeVars = scopeVars;
                this.marker = marker;
                this.lastCloseScopePos = lastCloseScopePos;
            }

            // Enable comparisons between nil and funcState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(funcState value, NilType nil) => value.Equals(default(funcState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(funcState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, funcState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, funcState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator funcState(NilType nil) => default(funcState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static funcState funcState_cast(dynamic value)
        {
            return new funcState(value.scopeVars, value.marker, value.lastCloseScopePos);
        }
    }
}}}}