//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:12:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using syntax = go.cmd.compile.@internal.syntax_package;
using fmt = go.fmt_package;
using atomic = go.sync.atomic_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Interface
        {
            // Constructors
            public Interface(NilType _)
            {
                this.methods = default;
                this.types = default;
                this.embeddeds = default;
                this.allMethods = default;
                this.allTypes = default;
                this.obj = default;
            }

            public Interface(slice<ptr<Func>> methods = default, Type types = default, slice<Type> embeddeds = default, slice<ptr<Func>> allMethods = default, Type allTypes = default, Object obj = default)
            {
                this.methods = methods;
                this.types = types;
                this.embeddeds = embeddeds;
                this.allMethods = allMethods;
                this.allTypes = allTypes;
                this.obj = obj;
            }

            // Enable comparisons between nil and Interface struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Interface value, NilType nil) => value.Equals(default(Interface));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Interface value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Interface value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Interface value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Interface(NilType nil) => default(Interface);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Interface Interface_cast(dynamic value)
        {
            return new Interface(value.methods, value.types, value.embeddeds, value.allMethods, value.allTypes, value.obj);
        }
    }
}}}}