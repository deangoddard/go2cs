//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:13:33 UTC
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
        private partial struct dirFS
        {
            // Value of the dirFS struct
            private readonly @string m_value;
            
            public dirFS(@string value) => m_value = value;

            // Enable implicit conversions between @string and dirFS struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dirFS(@string value) => new dirFS(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(dirFS value) => value.m_value;
            
            // Enable comparisons between nil and dirFS struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dirFS value, NilType nil) => value.Equals(default(dirFS));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dirFS value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dirFS value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dirFS value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dirFS(NilType nil) => default(dirFS);
        }
    }
}
