//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lazyFlag
        {
            // Value of the lazyFlag struct
            private readonly ulong m_value;
            
            public lazyFlag(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and lazyFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lazyFlag(ulong value) => new lazyFlag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(lazyFlag value) => value.m_value;
            
            // Enable comparisons between nil and lazyFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lazyFlag value, NilType nil) => value.Equals(default(lazyFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lazyFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lazyFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lazyFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lazyFlag(NilType nil) => default(lazyFlag);
        }
    }
}
