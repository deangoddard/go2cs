//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:04:27 UTC
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
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class asmdecl_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct asmKind
        {
            // Value of the asmKind struct
            private readonly long m_value;

            public asmKind(long value) => m_value = value;

            // Enable implicit conversions between long and asmKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator asmKind(long value) => new asmKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(asmKind value) => value.m_value;
            
            // Enable comparisons between nil and asmKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(asmKind value, NilType nil) => value.Equals(default(asmKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(asmKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, asmKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, asmKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator asmKind(NilType nil) => default(asmKind);
        }
    }
}}}}}}}}}
