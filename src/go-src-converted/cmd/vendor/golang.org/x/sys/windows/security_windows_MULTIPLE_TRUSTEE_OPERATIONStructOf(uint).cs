//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:36 UTC
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
        public partial struct MULTIPLE_TRUSTEE_OPERATION
        {
            // Value of the MULTIPLE_TRUSTEE_OPERATION struct
            private readonly uint m_value;
            
            public MULTIPLE_TRUSTEE_OPERATION(uint value) => m_value = value;

            // Enable implicit conversions between uint and MULTIPLE_TRUSTEE_OPERATION struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MULTIPLE_TRUSTEE_OPERATION(uint value) => new MULTIPLE_TRUSTEE_OPERATION(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(MULTIPLE_TRUSTEE_OPERATION value) => value.m_value;
            
            // Enable comparisons between nil and MULTIPLE_TRUSTEE_OPERATION struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MULTIPLE_TRUSTEE_OPERATION value, NilType nil) => value.Equals(default(MULTIPLE_TRUSTEE_OPERATION));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MULTIPLE_TRUSTEE_OPERATION value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MULTIPLE_TRUSTEE_OPERATION value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MULTIPLE_TRUSTEE_OPERATION value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MULTIPLE_TRUSTEE_OPERATION(NilType nil) => default(MULTIPLE_TRUSTEE_OPERATION);
        }
    }
}}}}}}
