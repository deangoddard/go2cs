//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using token = go.go.token_package;
using types = go.go.types_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using atomic = go.sync.atomic_package;
using ssa = go.golang.org.x.tools.go.ssa_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace ssa
{
    public static partial class interp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct interpreter
        {
            // Constructors
            public interpreter(NilType _)
            {
                this.osArgs = default;
                this.prog = default;
                this.globals = default;
                this.mode = default;
                this.reflectPackage = default;
                this.errorMethods = default;
                this.rtypeMethods = default;
                this.runtimeErrorString = default;
                this.sizes = default;
                this.goroutines = default;
            }

            public interpreter(slice<value> osArgs = default, ref ptr<ssa.Program> prog = default, map<ssa.Value, ptr<value>> globals = default, Mode mode = default, ref ptr<ssa.Package> reflectPackage = default, methodSet errorMethods = default, methodSet rtypeMethods = default, types.Type runtimeErrorString = default, types.Sizes sizes = default, int goroutines = default)
            {
                this.osArgs = osArgs;
                this.prog = prog;
                this.globals = globals;
                this.mode = mode;
                this.reflectPackage = reflectPackage;
                this.errorMethods = errorMethods;
                this.rtypeMethods = rtypeMethods;
                this.runtimeErrorString = runtimeErrorString;
                this.sizes = sizes;
                this.goroutines = goroutines;
            }

            // Enable comparisons between nil and interpreter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(interpreter value, NilType nil) => value.Equals(default(interpreter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(interpreter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, interpreter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, interpreter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator interpreter(NilType nil) => default(interpreter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static interpreter interpreter_cast(dynamic value)
        {
            return new interpreter(value.osArgs, ref value.prog, value.globals, value.mode, ref value.reflectPackage, value.errorMethods, value.rtypeMethods, value.runtimeErrorString, value.sizes, value.goroutines);
        }
    }
}}}}}}