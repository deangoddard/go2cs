//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class aliases_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct V2
        {
            // Value of the V2 struct
            private readonly V3 m_value;
            
            public V2(V3 value) => m_value = value;

            // Enable implicit conversions between V3 and V2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator V2(V3 value) => new V2(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator V3(V2 value) => value.m_value;
            
            // Enable comparisons between nil and V2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(V2 value, NilType nil) => value.Equals(default(V2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(V2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, V2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, V2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator V2(NilType nil) => default(V2);
        }
    }
}}}
