//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class print_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorTest5
        {
            // Value of the errorTest5 struct
            private readonly long m_value;

            public errorTest5(long value) => m_value = value;

            // Enable implicit conversions between long and errorTest5 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorTest5(long value) => new errorTest5(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(errorTest5 value) => value.m_value;
            
            // Enable comparisons between nil and errorTest5 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorTest5 value, NilType nil) => value.Equals(default(errorTest5));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorTest5 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorTest5 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorTest5 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorTest5(NilType nil) => default(errorTest5);
        }
    }
}}}}
