//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hostLookupOrder
        {
            // Value of the hostLookupOrder struct
            private readonly long m_value;

            public hostLookupOrder(long value) => m_value = value;

            // Enable implicit conversions between long and hostLookupOrder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hostLookupOrder(long value) => new hostLookupOrder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(hostLookupOrder value) => value.m_value;
            
            // Enable comparisons between nil and hostLookupOrder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hostLookupOrder value, NilType nil) => value.Equals(default(hostLookupOrder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hostLookupOrder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hostLookupOrder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hostLookupOrder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hostLookupOrder(NilType nil) => default(hostLookupOrder);
        }
    }
}