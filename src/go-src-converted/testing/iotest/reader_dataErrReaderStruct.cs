//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using go;

namespace go {
namespace testing
{
    public static partial class iotest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dataErrReader
        {
            // Constructors
            public dataErrReader(NilType _)
            {
                this.r = default;
                this.unread = default;
                this.data = default;
            }

            public dataErrReader(io.Reader r = default, slice<byte> unread = default, slice<byte> data = default)
            {
                this.r = r;
                this.unread = unread;
                this.data = data;
            }

            // Enable comparisons between nil and dataErrReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dataErrReader value, NilType nil) => value.Equals(default(dataErrReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dataErrReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dataErrReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dataErrReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dataErrReader(NilType nil) => default(dataErrReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dataErrReader dataErrReader_cast(dynamic value)
        {
            return new dataErrReader(value.r, value.unread, value.data);
        }
    }
}}