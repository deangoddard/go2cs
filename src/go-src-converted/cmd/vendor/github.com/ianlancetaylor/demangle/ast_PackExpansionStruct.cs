//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PackExpansion
        {
            // Constructors
            public PackExpansion(NilType _)
            {
                this.Base = default;
                this.Pack = default;
            }

            public PackExpansion(AST Base = default, ref ptr<ArgumentPack> Pack = default)
            {
                this.Base = Base;
                this.Pack = Pack;
            }

            // Enable comparisons between nil and PackExpansion struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PackExpansion value, NilType nil) => value.Equals(default(PackExpansion));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PackExpansion value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PackExpansion value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PackExpansion value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PackExpansion(NilType nil) => default(PackExpansion);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PackExpansion PackExpansion_cast(dynamic value)
        {
            return new PackExpansion(value.Base, ref value.Pack);
        }
    }
}}}}}