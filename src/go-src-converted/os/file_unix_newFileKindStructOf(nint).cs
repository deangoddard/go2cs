//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:13:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct newFileKind
        {
            // Value of the newFileKind struct
            private readonly nint m_value;
            
            public newFileKind(nint value) => m_value = value;

            // Enable implicit conversions between nint and newFileKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newFileKind(nint value) => new newFileKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(newFileKind value) => value.m_value;
            
            // Enable comparisons between nil and newFileKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(newFileKind value, NilType nil) => value.Equals(default(newFileKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(newFileKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, newFileKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, newFileKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newFileKind(NilType nil) => default(newFileKind);
        }
    }
}