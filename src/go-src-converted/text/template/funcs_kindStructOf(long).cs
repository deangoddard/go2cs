//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace text
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct kind
        {
            // Value of the kind struct
            private readonly long m_value;

            public kind(long value) => m_value = value;

            // Enable implicit conversions between long and kind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator kind(long value) => new kind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(kind value) => value.m_value;
            
            // Enable comparisons between nil and kind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(kind value, NilType nil) => value.Equals(default(kind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(kind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, kind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, kind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator kind(NilType nil) => default(kind);
        }
    }
}}
