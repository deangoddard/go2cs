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
        private partial struct fmtTypeTypeIdName
        {
            // Value of the fmtTypeTypeIdName struct
            private readonly types.Type m_value;

            public fmtTypeTypeIdName(types.Type value) => m_value = value;

            // Enable implicit conversions between types.Type and fmtTypeTypeIdName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtTypeTypeIdName(types.Type value) => new fmtTypeTypeIdName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator types.Type(fmtTypeTypeIdName value) => value.m_value;
            
            // Enable comparisons between nil and fmtTypeTypeIdName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtTypeTypeIdName value, NilType nil) => value.Equals(default(fmtTypeTypeIdName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtTypeTypeIdName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtTypeTypeIdName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtTypeTypeIdName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtTypeTypeIdName(NilType nil) => default(fmtTypeTypeIdName);
        }
    }
}}}}
