//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct Function
        {
            // Constructors
            public Function(NilType _)
            {
                this.name = default;
                this.@object = default;
                this.method = default;
                this.Signature = default;
                this.pos = default;
                this.Synthetic = default;
                this.syntax = default;
                this.parent = default;
                this.Pkg = default;
                this.Prog = default;
                this.Params = default;
                this.FreeVars = default;
                this.Locals = default;
                this.Blocks = default;
                this.Recover = default;
                this.AnonFuncs = default;
                this.referrers = default;
                this.currentBlock = default;
                this.objects = default;
                this.namedResults = default;
                this.targets = default;
                this.lblocks = default;
            }

            public Function(@string name = default, types.Object @object = default, ref ptr<types.Selection> method = default, ref ptr<types.Signature> Signature = default, token.Pos pos = default, @string Synthetic = default, ast.Node syntax = default, ref ptr<Function> parent = default, ref ptr<Package> Pkg = default, ref ptr<Program> Prog = default, slice<ptr<Parameter>> Params = default, slice<ptr<FreeVar>> FreeVars = default, slice<ptr<Alloc>> Locals = default, slice<ptr<BasicBlock>> Blocks = default, ref ptr<BasicBlock> Recover = default, slice<ptr<Function>> AnonFuncs = default, slice<Instruction> referrers = default, ref ptr<BasicBlock> currentBlock = default, map<types.Object, Value> objects = default, slice<ptr<Alloc>> namedResults = default, ref ptr<targets> targets = default, map<ptr<ast.Object>, ptr<lblock>> lblocks = default)
            {
                this.name = name;
                this.@object = @object;
                this.method = method;
                this.Signature = Signature;
                this.pos = pos;
                this.Synthetic = Synthetic;
                this.syntax = syntax;
                this.parent = parent;
                this.Pkg = Pkg;
                this.Prog = Prog;
                this.Params = Params;
                this.FreeVars = FreeVars;
                this.Locals = Locals;
                this.Blocks = Blocks;
                this.Recover = Recover;
                this.AnonFuncs = AnonFuncs;
                this.referrers = referrers;
                this.currentBlock = currentBlock;
                this.objects = objects;
                this.namedResults = namedResults;
                this.targets = targets;
                this.lblocks = lblocks;
            }

            // Enable comparisons between nil and Function struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Function value, NilType nil) => value.Equals(default(Function));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Function value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Function value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Function value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Function(NilType nil) => default(Function);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Function Function_cast(dynamic value)
        {
            return new Function(value.name, value.@object, ref value.method, ref value.Signature, value.pos, value.Synthetic, value.syntax, ref value.parent, ref value.Pkg, ref value.Prog, value.Params, value.FreeVars, value.Locals, value.Blocks, ref value.Recover, value.AnonFuncs, value.referrers, ref value.currentBlock, value.objects, value.namedResults, ref value.targets, value.lblocks);
        }
    }
}}}}}