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
        private partial struct byMaskLength
        {
            // Value of the byMaskLength struct
            private readonly slice<policyTableEntry> m_value;

            public byMaskLength(slice<policyTableEntry> value) => m_value = value;

            // Enable implicit conversions between slice<policyTableEntry> and byMaskLength struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byMaskLength(slice<policyTableEntry> value) => new byMaskLength(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<policyTableEntry>(byMaskLength value) => value.m_value;
            
            // Enable comparisons between nil and byMaskLength struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byMaskLength value, NilType nil) => value.Equals(default(byMaskLength));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byMaskLength value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byMaskLength value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byMaskLength value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byMaskLength(NilType nil) => default(byMaskLength);
        }
    }
}
