//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:09 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace @internal
{
    public static partial class analysisflags_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct triState
        {
            // Value of the triState struct
            private readonly nint m_value;
            
            public triState(nint value) => m_value = value;

            // Enable implicit conversions between nint and triState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator triState(nint value) => new triState(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(triState value) => value.m_value;
            
            // Enable comparisons between nil and triState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(triState value, NilType nil) => value.Equals(default(triState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(triState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, triState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, triState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator triState(NilType nil) => default(triState);
        }
    }
}}}}}}}}}
