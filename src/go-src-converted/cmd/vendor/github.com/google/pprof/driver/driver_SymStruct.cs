//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using http = go.net.http_package;
using regexp = go.regexp_package;
using time = go.time_package;
using internaldriver = go.github.com.google.pprof.@internal.driver_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Sym
        {
            // Constructors
            public Sym(NilType _)
            {
                this.Name = default;
                this.File = default;
                this.Start = default;
                this.End = default;
            }

            public Sym(slice<@string> Name = default, @string File = default, ulong Start = default, ulong End = default)
            {
                this.Name = Name;
                this.File = File;
                this.Start = Start;
                this.End = End;
            }

            // Enable comparisons between nil and Sym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sym value, NilType nil) => value.Equals(default(Sym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sym(NilType nil) => default(Sym);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Sym Sym_cast(dynamic value)
        {
            return new Sym(value.Name, value.File, value.Start, value.End);
        }
    }
}}}}}}