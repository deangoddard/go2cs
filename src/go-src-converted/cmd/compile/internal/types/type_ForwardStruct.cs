//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:47:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Forward
        {
            // Constructors
            public Forward(NilType _)
            {
                this.Copyto = default;
                this.Embedlineno = default;
            }

            public Forward(slice<ptr<Type>> Copyto = default, src.XPos Embedlineno = default)
            {
                this.Copyto = Copyto;
                this.Embedlineno = Embedlineno;
            }

            // Enable comparisons between nil and Forward struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Forward value, NilType nil) => value.Equals(default(Forward));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Forward value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Forward value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Forward value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Forward(NilType nil) => default(Forward);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Forward Forward_cast(dynamic value)
        {
            return new Forward(value.Copyto, value.Embedlineno);
        }
    }
}}}}