//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct metricKind
        {
            // Value of the metricKind struct
            private readonly nint m_value;
            
            public metricKind(nint value) => m_value = value;

            // Enable implicit conversions between nint and metricKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator metricKind(nint value) => new metricKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(metricKind value) => value.m_value;
            
            // Enable comparisons between nil and metricKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(metricKind value, NilType nil) => value.Equals(default(metricKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(metricKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, metricKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, metricKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator metricKind(NilType nil) => default(metricKind);
        }
    }
}
