//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SelectDir
        {
            // Value of the SelectDir struct
            private readonly nint m_value;
            
            public SelectDir(nint value) => m_value = value;

            // Enable implicit conversions between nint and SelectDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SelectDir(nint value) => new SelectDir(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(SelectDir value) => value.m_value;
            
            // Enable comparisons between nil and SelectDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SelectDir value, NilType nil) => value.Equals(default(SelectDir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SelectDir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SelectDir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SelectDir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SelectDir(NilType nil) => default(SelectDir);
        }
    }
}
