//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:28:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using gcprog = go.cmd.@internal.gcprog_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using os = go.os_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct GCProg
        {
            // Constructors
            public GCProg(NilType _)
            {
                this.lsym = default;
                this.symoff = default;
                this.w = default;
            }

            public GCProg(ref ptr<obj.LSym> lsym = default, long symoff = default, gcprog.Writer w = default)
            {
                this.lsym = lsym;
                this.symoff = symoff;
                this.w = w;
            }

            // Enable comparisons between nil and GCProg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(GCProg value, NilType nil) => value.Equals(default(GCProg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(GCProg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, GCProg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, GCProg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator GCProg(NilType nil) => default(GCProg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static GCProg GCProg_cast(dynamic value)
        {
            return new GCProg(ref value.lsym, value.symoff, value.w);
        }
    }
}}}}