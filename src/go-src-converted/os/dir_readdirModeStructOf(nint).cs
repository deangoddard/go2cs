//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:42 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct readdirMode
        {
            // Value of the readdirMode struct
            private readonly nint m_value;
            
            public readdirMode(nint value) => m_value = value;

            // Enable implicit conversions between nint and readdirMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readdirMode(nint value) => new readdirMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(readdirMode value) => value.m_value;
            
            // Enable comparisons between nil and readdirMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readdirMode value, NilType nil) => value.Equals(default(readdirMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readdirMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readdirMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readdirMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readdirMode(NilType nil) => default(readdirMode);
        }
    }
}
