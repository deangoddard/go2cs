//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:24:56 UTC
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
        private partial struct fileAndPairs
        {
            // Value of the fileAndPairs struct
            private readonly slice<fileAndPair> m_value;

            public fileAndPairs(slice<fileAndPair> value) => m_value = value;

            // Enable implicit conversions between slice<fileAndPair> and fileAndPairs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileAndPairs(slice<fileAndPair> value) => new fileAndPairs(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<fileAndPair>(fileAndPairs value) => value.m_value;
            
            // Enable comparisons between nil and fileAndPairs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileAndPairs value, NilType nil) => value.Equals(default(fileAndPairs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileAndPairs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileAndPairs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileAndPairs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileAndPairs(NilType nil) => default(fileAndPairs);
        }
    }
}}}}
