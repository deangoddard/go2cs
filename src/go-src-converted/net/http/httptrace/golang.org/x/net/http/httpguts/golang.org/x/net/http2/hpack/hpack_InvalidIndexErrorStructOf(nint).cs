//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InvalidIndexError
        {
            // Value of the InvalidIndexError struct
            private readonly nint m_value;
            
            public InvalidIndexError(nint value) => m_value = value;

            // Enable implicit conversions between nint and InvalidIndexError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidIndexError(nint value) => new InvalidIndexError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(InvalidIndexError value) => value.m_value;
            
            // Enable comparisons between nil and InvalidIndexError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InvalidIndexError value, NilType nil) => value.Equals(default(InvalidIndexError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InvalidIndexError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InvalidIndexError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InvalidIndexError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidIndexError(NilType nil) => default(InvalidIndexError);
        }
    }
}}}}}
