//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:53:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct orderEventList
        {
            // Value of the orderEventList struct
            private readonly slice<orderEvent> m_value;

            public orderEventList(slice<orderEvent> value) => m_value = value;

            // Enable implicit conversions between slice<orderEvent> and orderEventList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator orderEventList(slice<orderEvent> value) => new orderEventList(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<orderEvent>(orderEventList value) => value.m_value;
            
            // Enable comparisons between nil and orderEventList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(orderEventList value, NilType nil) => value.Equals(default(orderEventList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(orderEventList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, orderEventList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, orderEventList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator orderEventList(NilType nil) => default(orderEventList);
        }
    }
}}
