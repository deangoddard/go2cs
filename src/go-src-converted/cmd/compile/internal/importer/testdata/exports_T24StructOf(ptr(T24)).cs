//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:27:22 UTC
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
namespace compile {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct T24
        {
            // Value of the T24 struct
            private readonly ptr<T24> m_value;
            
            public T24(ptr<T24> value) => m_value = value;

            // Enable implicit conversions between ptr<T24> and T24 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T24(ptr<T24> value) => new T24(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptr<T24>(T24 value) => value.m_value;
            
            // Enable comparisons between nil and T24 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T24 value, NilType nil) => value.Equals(default(T24));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T24 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T24 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T24 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T24(NilType nil) => default(T24);
        }
    }
}}}}
