//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:50:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class benchmark_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Flags
        {
            // Value of the Flags struct
            private readonly long m_value;

            public Flags(long value) => m_value = value;

            // Enable implicit conversions between long and Flags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Flags(long value) => new Flags(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(Flags value) => value.m_value;
            
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
}}}}
