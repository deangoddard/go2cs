//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace runtime {
namespace @internal
{
    public static partial class sys_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ArchFamilyType
        {
            // Value of the ArchFamilyType struct
            private readonly nint m_value;
            
            public ArchFamilyType(nint value) => m_value = value;

            // Enable implicit conversions between nint and ArchFamilyType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ArchFamilyType(nint value) => new ArchFamilyType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(ArchFamilyType value) => value.m_value;
            
            // Enable comparisons between nil and ArchFamilyType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ArchFamilyType value, NilType nil) => value.Equals(default(ArchFamilyType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ArchFamilyType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ArchFamilyType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ArchFamilyType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ArchFamilyType(NilType nil) => default(ArchFamilyType);
        }
    }
}}}
