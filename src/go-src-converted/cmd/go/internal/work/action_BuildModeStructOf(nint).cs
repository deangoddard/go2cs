//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:16:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class work_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BuildMode
        {
            // Value of the BuildMode struct
            private readonly nint m_value;
            
            public BuildMode(nint value) => m_value = value;

            // Enable implicit conversions between nint and BuildMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildMode(nint value) => new BuildMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(BuildMode value) => value.m_value;
            
            // Enable comparisons between nil and BuildMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BuildMode value, NilType nil) => value.Equals(default(BuildMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BuildMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BuildMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BuildMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildMode(NilType nil) => default(BuildMode);
        }
    }
}}}}
