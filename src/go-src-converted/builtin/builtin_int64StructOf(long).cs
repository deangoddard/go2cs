//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct int64
        {
            // Value of the int64 struct
            private readonly long m_value;

            public int64(long value) => m_value = value;

            // Enable implicit conversions between long and int64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int64(long value) => new int64(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(int64 value) => value.m_value;
            
            // Enable comparisons between nil and int64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(int64 value, NilType nil) => value.Equals(default(int64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(int64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, int64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, int64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int64(NilType nil) => default(int64);
        }
    }
}
