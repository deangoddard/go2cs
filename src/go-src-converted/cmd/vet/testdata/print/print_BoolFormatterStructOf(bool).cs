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
        public partial struct BoolFormatter
        {
            // Value of the BoolFormatter struct
            private readonly bool m_value;

            public BoolFormatter(bool value) => m_value = value;

            // Enable implicit conversions between bool and BoolFormatter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BoolFormatter(bool value) => new BoolFormatter(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bool(BoolFormatter value) => value.m_value;
            
            // Enable comparisons between nil and BoolFormatter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BoolFormatter value, NilType nil) => value.Equals(default(BoolFormatter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BoolFormatter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BoolFormatter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BoolFormatter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BoolFormatter(NilType nil) => default(BoolFormatter);
        }
    }
}}}}
