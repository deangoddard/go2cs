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
        private partial struct fmtMode
        {
            // Value of the fmtMode struct
            private readonly long m_value;

            public fmtMode(long value) => m_value = value;

            // Enable implicit conversions between long and fmtMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtMode(long value) => new fmtMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(fmtMode value) => value.m_value;
            
            // Enable comparisons between nil and fmtMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtMode value, NilType nil) => value.Equals(default(fmtMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtMode(NilType nil) => default(fmtMode);
        }
    }
}}}}