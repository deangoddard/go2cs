//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:51:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fileAddr
        {
            // Value of the fileAddr struct
            private readonly @string m_value;

            public fileAddr(@string value) => m_value = value;

            // Enable implicit conversions between @string and fileAddr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileAddr(@string value) => new fileAddr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(fileAddr value) => value.m_value;
            
            // Enable comparisons between nil and fileAddr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileAddr value, NilType nil) => value.Equals(default(fileAddr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileAddr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileAddr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileAddr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileAddr(NilType nil) => default(fileAddr);
        }
    }
}
