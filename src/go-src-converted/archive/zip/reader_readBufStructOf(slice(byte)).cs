//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:45:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct readBuf
        {
            // Value of the readBuf struct
            private readonly slice<byte> m_value;

            public readBuf(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and readBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readBuf(slice<byte> value) => new readBuf(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(readBuf value) => value.m_value;
            
            // Enable comparisons between nil and readBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readBuf value, NilType nil) => value.Equals(default(readBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readBuf(NilType nil) => default(readBuf);
        }
    }
}}
