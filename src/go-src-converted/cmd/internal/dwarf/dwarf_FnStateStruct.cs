//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:57:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using exec = go.@internal.execabs_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using objabi = go.cmd.@internal.objabi_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class dwarf_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct FnState
        {
            // Constructors
            public FnState(NilType _)
            {
                this.Name = default;
                this.Importpath = default;
                this.Info = default;
                this.Filesym = default;
                this.Loc = default;
                this.Ranges = default;
                this.Absfn = default;
                this.StartPC = default;
                this.Size = default;
                this.External = default;
                this.Scopes = default;
                this.InlCalls = default;
                this.UseBASEntries = default;
            }

            public FnState(@string Name = default, @string Importpath = default, Sym Info = default, Sym Filesym = default, Sym Loc = default, Sym Ranges = default, Sym Absfn = default, Sym StartPC = default, long Size = default, bool External = default, slice<Scope> Scopes = default, InlCalls InlCalls = default, bool UseBASEntries = default)
            {
                this.Name = Name;
                this.Importpath = Importpath;
                this.Info = Info;
                this.Filesym = Filesym;
                this.Loc = Loc;
                this.Ranges = Ranges;
                this.Absfn = Absfn;
                this.StartPC = StartPC;
                this.Size = Size;
                this.External = External;
                this.Scopes = Scopes;
                this.InlCalls = InlCalls;
                this.UseBASEntries = UseBASEntries;
            }

            // Enable comparisons between nil and FnState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FnState value, NilType nil) => value.Equals(default(FnState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FnState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FnState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FnState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FnState(NilType nil) => default(FnState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static FnState FnState_cast(dynamic value)
        {
            return new FnState(value.Name, value.Importpath, value.Info, value.Filesym, value.Loc, value.Ranges, value.Absfn, value.StartPC, value.Size, value.External, value.Scopes, value.InlCalls, value.UseBASEntries);
        }
    }
}}}