//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:51:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SymKind
        {
            // Value of the SymKind struct
            private readonly byte m_value;

            public SymKind(byte value) => m_value = value;

            // Enable implicit conversions between byte and SymKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SymKind(byte value) => new SymKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(SymKind value) => value.m_value;
            
            // Enable comparisons between nil and SymKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SymKind value, NilType nil) => value.Equals(default(SymKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SymKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SymKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SymKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SymKind(NilType nil) => default(SymKind);
        }
    }
}}}}
