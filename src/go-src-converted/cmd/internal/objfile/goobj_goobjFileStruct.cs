//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using goobj = go.cmd.@internal.goobj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using dwarf = go.debug.dwarf_package;
using gosym = go.debug.gosym_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using os = go.os_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct goobjFile
        {
            // Constructors
            public goobjFile(NilType _)
            {
                this.goobj = default;
                this.f = default;
            }

            public goobjFile(ref ptr<goobj.Package> goobj = default, ref ptr<os.File> f = default)
            {
                this.goobj = goobj;
                this.f = f;
            }

            // Enable comparisons between nil and goobjFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(goobjFile value, NilType nil) => value.Equals(default(goobjFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(goobjFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, goobjFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, goobjFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator goobjFile(NilType nil) => default(goobjFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static goobjFile goobjFile_cast(dynamic value)
        {
            return new goobjFile(ref value.goobj, ref value.f);
        }
    }
}}}