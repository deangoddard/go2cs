//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:32:23 UTC
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
namespace @internal
{
    public static partial class objabi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncFlag
        {
            // Value of the FuncFlag struct
            private readonly byte m_value;
            
            public FuncFlag(byte value) => m_value = value;

            // Enable implicit conversions between byte and FuncFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncFlag(byte value) => new FuncFlag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(FuncFlag value) => value.m_value;
            
            // Enable comparisons between nil and FuncFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncFlag value, NilType nil) => value.Equals(default(FuncFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncFlag(NilType nil) => default(FuncFlag);
        }
    }
}}}
