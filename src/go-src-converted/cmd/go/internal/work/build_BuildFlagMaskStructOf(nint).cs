//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:41 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct BuildFlagMask
        {
            // Value of the BuildFlagMask struct
            private readonly nint m_value;
            
            public BuildFlagMask(nint value) => m_value = value;

            // Enable implicit conversions between nint and BuildFlagMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildFlagMask(nint value) => new BuildFlagMask(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(BuildFlagMask value) => value.m_value;
            
            // Enable comparisons between nil and BuildFlagMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BuildFlagMask value, NilType nil) => value.Equals(default(BuildFlagMask));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BuildFlagMask value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BuildFlagMask value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BuildFlagMask value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildFlagMask(NilType nil) => default(BuildFlagMask);
        }
    }
}}}}
