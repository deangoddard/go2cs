//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sync = go.sync_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Package
        {
            // Constructors
            public Package(NilType _)
            {
                this.Prog = default;
                this.Pkg = default;
                this.Members = default;
                this.values = default;
                this.init = default;
                this.debug = default;
                this.buildOnce = default;
                this.ninit = default;
                this.info = default;
                this.files = default;
            }

            public Package(ref ptr<Program> Prog = default, ref ptr<types.Package> Pkg = default, map<@string, Member> Members = default, map<types.Object, Value> values = default, ref ptr<Function> init = default, bool debug = default, sync.Once buildOnce = default, int ninit = default, ref ptr<types.Info> info = default, slice<ptr<ast.File>> files = default)
            {
                this.Prog = Prog;
                this.Pkg = Pkg;
                this.Members = Members;
                this.values = values;
                this.init = init;
                this.debug = debug;
                this.buildOnce = buildOnce;
                this.ninit = ninit;
                this.info = info;
                this.files = files;
            }

            // Enable comparisons between nil and Package struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Package value, NilType nil) => value.Equals(default(Package));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Package value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Package value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Package value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Package(NilType nil) => default(Package);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Package Package_cast(dynamic value)
        {
            return new Package(ref value.Prog, ref value.Pkg, value.Members, value.values, ref value.init, value.debug, value.buildOnce, value.ninit, ref value.info, value.files);
        }
    }
}}}}}