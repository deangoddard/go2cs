//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.debug.dwarf_package;
using pe = go.debug.pe_package;
using fmt = go.fmt_package;
using io = go.io_package;
using sort = go.sort_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct peFile
        {
            // Constructors
            public peFile(NilType _)
            {
                this.pe = default;
            }

            public peFile(ref ptr<pe.File> pe = default)
            {
                this.pe = pe;
            }

            // Enable comparisons between nil and peFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(peFile value, NilType nil) => value.Equals(default(peFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(peFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, peFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, peFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peFile(NilType nil) => default(peFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static peFile peFile_cast(dynamic value)
        {
            return new peFile(ref value.pe);
        }
    }
}}}