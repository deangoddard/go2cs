//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:26:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Flags
        {
            // Value of the Flags struct
            private readonly ulong m_value;

            public Flags(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and Flags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Flags(ulong value) => new Flags(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(Flags value) => value.m_value;
            
            // Enable comparisons between nil and Flags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Flags value, NilType nil) => value.Equals(default(Flags));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Flags value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Flags value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Flags value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Flags(NilType nil) => default(Flags);
        }
    }
}
