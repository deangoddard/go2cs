//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct scope
        {
            // Value of the scope struct
            private readonly byte m_value;

            public scope(byte value) => m_value = value;

            // Enable implicit conversions between byte and scope struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scope(byte value) => new scope(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(scope value) => value.m_value;
            
            // Enable comparisons between nil and scope struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(scope value, NilType nil) => value.Equals(default(scope));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(scope value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, scope value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, scope value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scope(NilType nil) => default(scope);
        }
    }
}
