//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
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
        public partial struct BranchPrediction
        {
            // Value of the BranchPrediction struct
            private readonly sbyte m_value;
            
            public BranchPrediction(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and BranchPrediction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BranchPrediction(sbyte value) => new BranchPrediction(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(BranchPrediction value) => value.m_value;
            
            // Enable comparisons between nil and BranchPrediction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BranchPrediction value, NilType nil) => value.Equals(default(BranchPrediction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BranchPrediction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BranchPrediction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BranchPrediction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BranchPrediction(NilType nil) => default(BranchPrediction);
        }
    }
}}}}
