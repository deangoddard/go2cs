//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using strconv = go.strconv_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class base32_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct newlineFilteringReader
        {
            // Constructors
            public newlineFilteringReader(NilType _)
            {
                this.wrapped = default;
            }

            public newlineFilteringReader(io.Reader wrapped = default)
            {
                this.wrapped = wrapped;
            }

            // Enable comparisons between nil and newlineFilteringReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(newlineFilteringReader value, NilType nil) => value.Equals(default(newlineFilteringReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(newlineFilteringReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, newlineFilteringReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, newlineFilteringReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator newlineFilteringReader(NilType nil) => default(newlineFilteringReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static newlineFilteringReader newlineFilteringReader_cast(dynamic value)
        {
            return new newlineFilteringReader(value.wrapped);
        }
    }
}}