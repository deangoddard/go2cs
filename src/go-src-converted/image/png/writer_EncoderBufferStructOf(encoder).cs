//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace image
{
    public static partial class png_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct EncoderBuffer
        {
            // Value of the EncoderBuffer struct
            private readonly encoder m_value;

            public EncoderBuffer(encoder value) => m_value = value;

            // Enable implicit conversions between encoder and EncoderBuffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EncoderBuffer(encoder value) => new EncoderBuffer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encoder(EncoderBuffer value) => value.m_value;
            
            // Enable comparisons between nil and EncoderBuffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EncoderBuffer value, NilType nil) => value.Equals(default(EncoderBuffer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EncoderBuffer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EncoderBuffer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EncoderBuffer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EncoderBuffer(NilType nil) => default(EncoderBuffer);
        }
    }
}}
