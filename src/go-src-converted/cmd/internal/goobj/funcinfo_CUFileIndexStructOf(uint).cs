//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:32:26 UTC
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
namespace @internal
{
    public static partial class goobj_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CUFileIndex
        {
            // Value of the CUFileIndex struct
            private readonly uint m_value;
            
            public CUFileIndex(uint value) => m_value = value;

            // Enable implicit conversions between uint and CUFileIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CUFileIndex(uint value) => new CUFileIndex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(CUFileIndex value) => value.m_value;
            
            // Enable comparisons between nil and CUFileIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CUFileIndex value, NilType nil) => value.Equals(default(CUFileIndex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CUFileIndex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CUFileIndex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CUFileIndex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CUFileIndex(NilType nil) => default(CUFileIndex);
        }
    }
}}}
