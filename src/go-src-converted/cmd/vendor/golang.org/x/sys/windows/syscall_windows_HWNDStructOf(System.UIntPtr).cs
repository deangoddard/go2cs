//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
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
        public partial struct HWND
        {
            // Value of the HWND struct
            private readonly System.UIntPtr m_value;
            
            public HWND(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and HWND struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HWND(System.UIntPtr value) => new HWND(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(HWND value) => value.m_value;
            
            // Enable comparisons between nil and HWND struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HWND value, NilType nil) => value.Equals(default(HWND));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HWND value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HWND value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HWND value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HWND(NilType nil) => default(HWND);
        }
    }
}}}}}}