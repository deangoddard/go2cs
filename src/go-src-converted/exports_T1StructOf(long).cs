//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T1
        {
            // Value of the T1 struct
            private readonly long m_value;

            public T1(long value) => m_value = value;

            // Enable implicit conversions between long and T1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1(long value) => new T1(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(T1 value) => value.m_value;
            
            // Enable comparisons between nil and T1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T1 value, NilType nil) => value.Equals(default(T1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T1(NilType nil) => default(T1);
        }
    }
}}}}}}