//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:27:06 UTC
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
        private partial struct fmtOpErr
        {
            // Value of the fmtOpErr struct
            private readonly Op m_value;

            public fmtOpErr(Op value) => m_value = value;

            // Enable implicit conversions between Op and fmtOpErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtOpErr(Op value) => new fmtOpErr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(fmtOpErr value) => value.m_value;
            
            // Enable comparisons between nil and fmtOpErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtOpErr value, NilType nil) => value.Equals(default(fmtOpErr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtOpErr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtOpErr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtOpErr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtOpErr(NilType nil) => default(fmtOpErr);
        }
    }
}}}}