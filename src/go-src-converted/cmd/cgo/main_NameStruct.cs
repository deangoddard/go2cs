//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:47:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using md5 = go.crypto.md5_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using printer = go.go.printer_package;
using token = go.go.token_package;
using buildcfg = go.@internal.buildcfg_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using edit = go.cmd.@internal.edit_package;
using objabi = go.cmd.@internal.objabi_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Name
        {
            // Constructors
            public Name(NilType _)
            {
                this.Go = default;
                this.Mangle = default;
                this.C = default;
                this.Define = default;
                this.Kind = default;
                this.Type = default;
                this.FuncType = default;
                this.AddError = default;
                this.Const = default;
            }

            public Name(@string Go = default, @string Mangle = default, @string C = default, @string Define = default, @string Kind = default, ref ptr<Type> Type = default, ref ptr<FuncType> FuncType = default, bool AddError = default, @string Const = default)
            {
                this.Go = Go;
                this.Mangle = Mangle;
                this.C = C;
                this.Define = Define;
                this.Kind = Kind;
                this.Type = Type;
                this.FuncType = FuncType;
                this.AddError = AddError;
                this.Const = Const;
            }

            // Enable comparisons between nil and Name struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Name value, NilType nil) => value.Equals(default(Name));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Name value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Name value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Name value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Name(NilType nil) => default(Name);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Name Name_cast(dynamic value)
        {
            return new Name(value.Go, value.Mangle, value.C, value.Define, value.Kind, ref value.Type, ref value.FuncType, value.AddError, value.Const);
        }
    }
}