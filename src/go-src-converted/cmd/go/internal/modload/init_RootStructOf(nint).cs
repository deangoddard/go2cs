//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:31:33 UTC
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
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Root
        {
            // Value of the Root struct
            private readonly nint m_value;
            
            public Root(nint value) => m_value = value;

            // Enable implicit conversions between nint and Root struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Root(nint value) => new Root(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Root value) => value.m_value;
            
            // Enable comparisons between nil and Root struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Root value, NilType nil) => value.Equals(default(Root));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Root value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Root value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Root value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Root(NilType nil) => default(Root);
        }
    }
}}}}
