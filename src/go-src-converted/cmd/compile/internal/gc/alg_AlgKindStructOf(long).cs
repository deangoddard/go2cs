//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:53:03 UTC
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
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct AlgKind
        {
            // Value of the AlgKind struct
            private readonly long m_value;

            public AlgKind(long value) => m_value = value;

            // Enable implicit conversions between long and AlgKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AlgKind(long value) => new AlgKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(AlgKind value) => value.m_value;
            
            // Enable comparisons between nil and AlgKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AlgKind value, NilType nil) => value.Equals(default(AlgKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AlgKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AlgKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AlgKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AlgKind(NilType nil) => default(AlgKind);
        }
    }
}}}}
