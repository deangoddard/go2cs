//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class sort_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Float64Slice
        {
            // Value of the Float64Slice struct
            private readonly slice<double> m_value;

            public Float64Slice(slice<double> value) => m_value = value;

            // Enable implicit conversions between slice<double> and Float64Slice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Float64Slice(slice<double> value) => new Float64Slice(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<double>(Float64Slice value) => value.m_value;
            
            // Enable comparisons between nil and Float64Slice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Float64Slice value, NilType nil) => value.Equals(default(Float64Slice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Float64Slice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Float64Slice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Float64Slice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Float64Slice(NilType nil) => default(Float64Slice);
        }
    }
}
