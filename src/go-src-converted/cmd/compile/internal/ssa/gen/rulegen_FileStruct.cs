//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:22:51 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(BodyBase))]
        public partial struct File
        {
            // BodyBase structure promotion - sourced from value copy
            private readonly ptr<BodyBase> m_BodyBaseRef;

            private ref BodyBase BodyBase_val => ref m_BodyBaseRef.Value;

            public ref slice<Statement> List => ref m_BodyBaseRef.Value.List;

            public ref bool CanFail => ref m_BodyBaseRef.Value.CanFail;

            // Constructors
            public File(NilType _)
            {
                this.m_BodyBaseRef = new ptr<BodyBase>(new BodyBase(nil));
                this.Arch = default;
                this.Suffix = default;
            }

            public File(BodyBase BodyBase = default, arch Arch = default, @string Suffix = default)
            {
                this.m_BodyBaseRef = new ptr<BodyBase>(BodyBase);
                this.Arch = Arch;
                this.Suffix = Suffix;
            }

            // Enable comparisons between nil and File struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File value, NilType nil) => value.Equals(default(File));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator File(NilType nil) => default(File);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static File File_cast(dynamic value)
        {
            return new File(value.BodyBase, value.Arch, value.Suffix);
        }
    }
}