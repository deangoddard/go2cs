//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct instArgs
        {
            // Value of the instArgs struct
            private readonly array<instArg> m_value;

            public instArgs(array<instArg> value) => m_value = value;

            // Enable implicit conversions between array<instArg> and instArgs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instArgs(array<instArg> value) => new instArgs(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<instArg>(instArgs value) => value.m_value;
            
            // Enable comparisons between nil and instArgs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(instArgs value, NilType nil) => value.Equals(default(instArgs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(instArgs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, instArgs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, instArgs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator instArgs(NilType nil) => default(instArgs);
        }
    }
}}}}}}}
