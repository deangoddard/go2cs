//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:09:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using format = go.go.format_package;
using parser = go.go.parser_package;
using printer = go.go.printer_package;
using token = go.go.token_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using path = go.path_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using astutil = go.golang.org.x.tools.go.ast.astutil_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct scope
        {
            // Constructors
            public scope(NilType _)
            {
                this.outer = default;
                this.objects = default;
            }

            public scope(ref ptr<scope> outer = default, map<@string, ptr<object>> objects = default)
            {
                this.outer = outer;
                this.objects = objects;
            }

            // Enable comparisons between nil and scope struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(scope value, NilType nil) => value.Equals(default(scope));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(scope value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, scope value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, scope value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scope(NilType nil) => default(scope);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static scope scope_cast(dynamic value)
        {
            return new scope(ref value.outer, value.objects);
        }
    }
}