//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:28:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pcsByPC
        {
            // Value of the pcsByPC struct
            private readonly slice<scopedPCs> m_value;

            public pcsByPC(slice<scopedPCs> value) => m_value = value;

            // Enable implicit conversions between slice<scopedPCs> and pcsByPC struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pcsByPC(slice<scopedPCs> value) => new pcsByPC(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<scopedPCs>(pcsByPC value) => value.m_value;
            
            // Enable comparisons between nil and pcsByPC struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pcsByPC value, NilType nil) => value.Equals(default(pcsByPC));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pcsByPC value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pcsByPC value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pcsByPC value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pcsByPC(NilType nil) => default(pcsByPC);
        }
    }
}}}}
