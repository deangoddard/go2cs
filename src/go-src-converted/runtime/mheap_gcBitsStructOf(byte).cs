//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcBits
        {
            // Value of the gcBits struct
            private readonly byte m_value;

            public gcBits(byte value) => m_value = value;

            // Enable implicit conversions between byte and gcBits struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcBits(byte value) => new gcBits(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(gcBits value) => value.m_value;
            
            // Enable comparisons between nil and gcBits struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcBits value, NilType nil) => value.Equals(default(gcBits));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcBits value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcBits value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcBits value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcBits(NilType nil) => default(gcBits);
        }
    }
}
