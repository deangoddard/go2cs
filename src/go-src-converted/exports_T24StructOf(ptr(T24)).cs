//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

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
}}}}}}
