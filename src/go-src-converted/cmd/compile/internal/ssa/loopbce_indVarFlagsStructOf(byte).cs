//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:24:50 UTC
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
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct indVarFlags
        {
            // Value of the indVarFlags struct
            private readonly byte m_value;

            public indVarFlags(byte value) => m_value = value;

            // Enable implicit conversions between byte and indVarFlags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator indVarFlags(byte value) => new indVarFlags(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(indVarFlags value) => value.m_value;
            
            // Enable comparisons between nil and indVarFlags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(indVarFlags value, NilType nil) => value.Equals(default(indVarFlags));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(indVarFlags value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, indVarFlags value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, indVarFlags value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator indVarFlags(NilType nil) => default(indVarFlags);
        }
    }
}}}}
