//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct htmlSig
        {
            // Value of the htmlSig struct
            private readonly slice<byte> m_value;

            public htmlSig(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and htmlSig struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator htmlSig(slice<byte> value) => new htmlSig(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(htmlSig value) => value.m_value;
            
            // Enable comparisons between nil and htmlSig struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(htmlSig value, NilType nil) => value.Equals(default(htmlSig));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(htmlSig value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, htmlSig value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, htmlSig value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator htmlSig(NilType nil) => default(htmlSig);
        }
    }
}}
