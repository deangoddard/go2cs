//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errString
        {
            // Value of the errString struct
            private readonly @string m_value;

            public errString(@string value) => m_value = value;

            // Enable implicit conversions between @string and errString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errString(@string value) => new errString(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(errString value) => value.m_value;
            
            // Enable comparisons between nil and errString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errString value, NilType nil) => value.Equals(default(errString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errString(NilType nil) => default(errString);
        }
    }
}}}}}}
