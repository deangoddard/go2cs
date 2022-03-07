//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:24:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct VectorType
        {
            // Constructors
            public VectorType(NilType _)
            {
                this.Dimension = default;
                this.Base = default;
            }

            public VectorType(AST Dimension = default, AST Base = default)
            {
                this.Dimension = Dimension;
                this.Base = Base;
            }

            // Enable comparisons between nil and VectorType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(VectorType value, NilType nil) => value.Equals(default(VectorType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(VectorType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, VectorType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, VectorType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator VectorType(NilType nil) => default(VectorType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static VectorType VectorType_cast(dynamic value)
        {
            return new VectorType(value.Dimension, value.Base);
        }
    }
}}}}}