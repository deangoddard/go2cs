//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
using fs = go.io.fs_package;
using os = go.os_package;
using strconv = go.strconv_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using codehost = go.cmd.go.@internal.modfetch.codehost_package;
using par = go.cmd.go.@internal.par_package;
using vcs = go.cmd.go.@internal.vcs_package;
using web = go.cmd.go.@internal.web_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errRepo
        {
            // Constructors
            public errRepo(NilType _)
            {
                this.modulePath = default;
                this.err = default;
            }

            public errRepo(@string modulePath = default, error err = default)
            {
                this.modulePath = modulePath;
                this.err = err;
            }

            // Enable comparisons between nil and errRepo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errRepo value, NilType nil) => value.Equals(default(errRepo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errRepo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errRepo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errRepo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errRepo(NilType nil) => default(errRepo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errRepo errRepo_cast(dynamic value)
        {
            return new errRepo(value.modulePath, value.err);
        }
    }
}}}}