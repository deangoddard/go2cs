//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:26 UTC
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
        public partial struct UnsupportedError
        {
            // Value of the UnsupportedError struct
            private readonly @string m_value;

            public UnsupportedError(@string value) => m_value = value;

            // Enable implicit conversions between @string and UnsupportedError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnsupportedError(@string value) => new UnsupportedError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(UnsupportedError value) => value.m_value;
            
            // Enable comparisons between nil and UnsupportedError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnsupportedError value, NilType nil) => value.Equals(default(UnsupportedError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnsupportedError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnsupportedError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnsupportedError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnsupportedError(NilType nil) => default(UnsupportedError);
        }
    }
}}
