//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace compress
{
    public static partial class lzw_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Order
        {
            // Value of the Order struct
            private readonly long m_value;

            public Order(long value) => m_value = value;

            // Enable implicit conversions between long and Order struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Order(long value) => new Order(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(Order value) => value.m_value;
            
            // Enable comparisons between nil and Order struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Order value, NilType nil) => value.Equals(default(Order));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Order value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Order value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Order value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Order(NilType nil) => default(Order);
        }
    }
}}
