//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:40 UTC
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
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct anyType
        {
            // Constructors
            public anyType(NilType _)
            {
            }
            // Enable comparisons between nil and anyType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(anyType value, NilType nil) => value.Equals(default(anyType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(anyType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, anyType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, anyType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator anyType(NilType nil) => default(anyType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static anyType anyType_cast(dynamic value)
        {
            return new anyType();
        }
    }
}}}