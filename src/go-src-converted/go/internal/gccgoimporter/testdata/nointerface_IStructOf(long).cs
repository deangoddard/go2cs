//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:56:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go {
namespace @internal
{
    public static partial class nointerface_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct I
        {
            // Value of the I struct
            private readonly long m_value;

            public I(long value) => m_value = value;

            // Enable implicit conversions between long and I struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator I(long value) => new I(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(I value) => value.m_value;
            
            // Enable comparisons between nil and I struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(I value, NilType nil) => value.Equals(default(I));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(I value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, I value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, I value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator I(NilType nil) => default(I);
        }
    }
}}}