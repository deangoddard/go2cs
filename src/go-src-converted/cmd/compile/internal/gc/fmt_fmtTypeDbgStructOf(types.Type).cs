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
        private partial struct fmtTypeDbg
        {
            // Value of the fmtTypeDbg struct
            private readonly types.Type m_value;

            public fmtTypeDbg(types.Type value) => m_value = value;

            // Enable implicit conversions between types.Type and fmtTypeDbg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtTypeDbg(types.Type value) => new fmtTypeDbg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator types.Type(fmtTypeDbg value) => value.m_value;
            
            // Enable comparisons between nil and fmtTypeDbg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtTypeDbg value, NilType nil) => value.Equals(default(fmtTypeDbg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtTypeDbg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtTypeDbg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtTypeDbg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtTypeDbg(NilType nil) => default(fmtTypeDbg);
        }
    }
}}}}
