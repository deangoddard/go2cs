//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T6c
        {
            // Value of the T6c struct
            private readonly channel<channel<long>> m_value;

            public T6c(channel<channel<long>> value) => m_value = value;

            // Enable implicit conversions between channel<channel<long>> and T6c struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T6c(channel<channel<long>> value) => new T6c(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator channel<channel<long>>(T6c value) => value.m_value;
            
            // Enable comparisons between nil and T6c struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T6c value, NilType nil) => value.Equals(default(T6c));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T6c value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T6c value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T6c value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T6c(NilType nil) => default(T6c);
        }
    }
}}}
