//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:18 UTC
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
namespace vet {
namespace testdata
{
    public static partial class method_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MethodTest
        {
            // Value of the MethodTest struct
            private readonly nint m_value;
            
            public MethodTest(nint value) => m_value = value;

            // Enable implicit conversions between nint and MethodTest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MethodTest(nint value) => new MethodTest(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(MethodTest value) => value.m_value;
            
            // Enable comparisons between nil and MethodTest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MethodTest value, NilType nil) => value.Equals(default(MethodTest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MethodTest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MethodTest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MethodTest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MethodTest(NilType nil) => default(MethodTest);
        }
    }
}}}}