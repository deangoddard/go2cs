//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MyInt64
        {
            // Value of the MyInt64 struct
            private readonly long m_value;

            public MyInt64(long value) => m_value = value;

            // Enable implicit conversions between long and MyInt64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyInt64(long value) => new MyInt64(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(MyInt64 value) => value.m_value;
            
            // Enable comparisons between nil and MyInt64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyInt64 value, NilType nil) => value.Equals(default(MyInt64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyInt64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyInt64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyInt64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyInt64(NilType nil) => default(MyInt64);
        }
    }
}
