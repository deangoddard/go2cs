//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:19 UTC
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
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct itag
        {
            // Value of the itag struct
            private readonly ulong m_value;
            
            public itag(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and itag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itag(ulong value) => new itag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(itag value) => value.m_value;
            
            // Enable comparisons between nil and itag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(itag value, NilType nil) => value.Equals(default(itag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(itag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, itag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, itag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator itag(NilType nil) => default(itag);
        }
    }
}}}
