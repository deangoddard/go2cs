//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:45:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace dns
{
    public static partial class dnsmessage_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct section
        {
            // Value of the section struct
            private readonly byte m_value;
            
            public section(byte value) => m_value = value;

            // Enable implicit conversions between byte and section struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator section(byte value) => new section(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(section value) => value.m_value;
            
            // Enable comparisons between nil and section struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(section value, NilType nil) => value.Equals(default(section));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(section value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, section value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, section value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator section(NilType nil) => default(section);
        }
    }
}}}}}}
