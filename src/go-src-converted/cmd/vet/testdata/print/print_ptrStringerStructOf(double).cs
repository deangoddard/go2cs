//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class print_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ptrStringer
        {
            // Value of the ptrStringer struct
            private readonly double m_value;

            public ptrStringer(double value) => m_value = value;

            // Enable implicit conversions between double and ptrStringer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptrStringer(double value) => new ptrStringer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator double(ptrStringer value) => value.m_value;
            
            // Enable comparisons between nil and ptrStringer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ptrStringer value, NilType nil) => value.Equals(default(ptrStringer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ptrStringer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ptrStringer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ptrStringer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptrStringer(NilType nil) => default(ptrStringer);
        }
    }
}}}}
