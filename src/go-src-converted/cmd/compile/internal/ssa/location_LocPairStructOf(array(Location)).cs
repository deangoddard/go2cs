//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:54:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LocPair
        {
            // Value of the LocPair struct
            private readonly array<Location> m_value;

            public LocPair(array<Location> value) => m_value = value;

            // Enable implicit conversions between array<Location> and LocPair struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LocPair(array<Location> value) => new LocPair(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<Location>(LocPair value) => value.m_value;
            
            // Enable comparisons between nil and LocPair struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LocPair value, NilType nil) => value.Equals(default(LocPair));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LocPair value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LocPair value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LocPair value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LocPair(NilType nil) => default(LocPair);
        }
    }
}}}}
