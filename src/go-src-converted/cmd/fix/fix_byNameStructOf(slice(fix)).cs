//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:44:57 UTC
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
        private partial struct byName
        {
            // Value of the byName struct
            private readonly slice<fix> m_value;

            public byName(slice<fix> value) => m_value = value;

            // Enable implicit conversions between slice<fix> and byName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byName(slice<fix> value) => new byName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<fix>(byName value) => value.m_value;
            
            // Enable comparisons between nil and byName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byName value, NilType nil) => value.Equals(default(byName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byName(NilType nil) => default(byName);
        }
    }
}
