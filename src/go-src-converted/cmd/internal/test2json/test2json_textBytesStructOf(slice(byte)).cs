//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class test2json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct textBytes
        {
            // Value of the textBytes struct
            private readonly slice<byte> m_value;

            public textBytes(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and textBytes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator textBytes(slice<byte> value) => new textBytes(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(textBytes value) => value.m_value;
            
            // Enable comparisons between nil and textBytes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(textBytes value, NilType nil) => value.Equals(default(textBytes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(textBytes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, textBytes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, textBytes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator textBytes(NilType nil) => default(textBytes);
        }
    }
}}}
