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
        public partial struct FmtFlag
        {
            // Value of the FmtFlag struct
            private readonly long m_value;

            public FmtFlag(long value) => m_value = value;

            // Enable implicit conversions between long and FmtFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FmtFlag(long value) => new FmtFlag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(FmtFlag value) => value.m_value;
            
            // Enable comparisons between nil and FmtFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FmtFlag value, NilType nil) => value.Equals(default(FmtFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FmtFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FmtFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FmtFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FmtFlag(NilType nil) => default(FmtFlag);
        }
    }
}}}}
