//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:47 UTC
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
namespace link {
namespace @internal
{
    public static partial class loadpe_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct peBiobuf
        {
            // Value of the peBiobuf struct
            private readonly bio.Reader m_value;
            
            public peBiobuf(bio.Reader value) => m_value = value;

            // Enable implicit conversions between bio.Reader and peBiobuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peBiobuf(bio.Reader value) => new peBiobuf(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bio.Reader(peBiobuf value) => value.m_value;
            
            // Enable comparisons between nil and peBiobuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(peBiobuf value, NilType nil) => value.Equals(default(peBiobuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(peBiobuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, peBiobuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, peBiobuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peBiobuf(NilType nil) => default(peBiobuf);
        }
    }
}}}}
