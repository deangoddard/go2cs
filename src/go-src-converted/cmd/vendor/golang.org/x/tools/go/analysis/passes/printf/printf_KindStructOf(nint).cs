//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:00 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class printf_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Kind
        {
            // Value of the Kind struct
            private readonly nint m_value;
            
            public Kind(nint value) => m_value = value;

            // Enable implicit conversions between nint and Kind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Kind(nint value) => new Kind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Kind value) => value.m_value;
            
            // Enable comparisons between nil and Kind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Kind value, NilType nil) => value.Equals(default(Kind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Kind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Kind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Kind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Kind(NilType nil) => default(Kind);
        }
    }
}}}}}}}}}
