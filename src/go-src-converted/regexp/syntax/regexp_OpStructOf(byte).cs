//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace regexp
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Op
        {
            // Value of the Op struct
            private readonly byte m_value;

            public Op(byte value) => m_value = value;

            // Enable implicit conversions between byte and Op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(byte value) => new Op(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(Op value) => value.m_value;
            
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
}}
