//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Interface
        {
            // Constructors
            public Interface(NilType _)
            {
                this.Fields = default;
            }

            public Interface(Fields Fields = default)
            {
                this.Fields = Fields;
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
            return new Interface(value.Fields);
        }
    }
}}}}