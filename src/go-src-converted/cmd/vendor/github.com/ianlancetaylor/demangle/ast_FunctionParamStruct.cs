//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:37:26 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct FunctionParam
        {
            // Constructors
            public FunctionParam(NilType _)
            {
                this.Index = default;
            }

            public FunctionParam(nint Index = default)
            {
                this.Index = Index;
            }

            // Enable comparisons between nil and FunctionParam struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FunctionParam value, NilType nil) => value.Equals(default(FunctionParam));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FunctionParam value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FunctionParam value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FunctionParam value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FunctionParam(NilType nil) => default(FunctionParam);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static FunctionParam FunctionParam_cast(dynamic value)
        {
            return new FunctionParam(value.Index);
        }
    }
}}}}}