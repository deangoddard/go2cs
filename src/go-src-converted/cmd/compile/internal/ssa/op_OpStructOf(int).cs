//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:54:11 UTC
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
        public partial struct Op
        {
            // Value of the Op struct
            private readonly int m_value;

            public Op(int value) => m_value = value;

            // Enable implicit conversions between int and Op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(int value) => new Op(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(Op value) => value.m_value;
            
            // Enable comparisons between nil and Op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Op value, NilType nil) => value.Equals(default(Op));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Op value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Op value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Op value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(NilType nil) => default(Op);
        }
    }
}}}}
