//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:41:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fmtOpTypeId
        {
            // Value of the fmtOpTypeId struct
            private readonly Op m_value;

            public fmtOpTypeId(Op value) => m_value = value;

            // Enable implicit conversions between Op and fmtOpTypeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtOpTypeId(Op value) => new fmtOpTypeId(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(fmtOpTypeId value) => value.m_value;
            
            // Enable comparisons between nil and fmtOpTypeId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtOpTypeId value, NilType nil) => value.Equals(default(fmtOpTypeId));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtOpTypeId value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtOpTypeId value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtOpTypeId value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtOpTypeId(NilType nil) => default(fmtOpTypeId);
        }
    }
}}}}
