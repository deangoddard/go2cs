//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using syntax = go.cmd.compile.@internal.syntax_package;
using types2 = go.cmd.compile.@internal.types2_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using io = go.io_package;
using big = go.math.big_package;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class importer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct intReader
        {
            // Constructors
            public intReader(NilType _)
            {
                this.Reader> = default;
                this.path = default;
            }

            public intReader(ref ptr<bytes.Reader> Reader> = default, @string path = default)
            {
                this.Reader> = Reader>;
                this.path = path;
            }

            // Enable comparisons between nil and intReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(intReader value, NilType nil) => value.Equals(default(intReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(intReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, intReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, intReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator intReader(NilType nil) => default(intReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static intReader intReader_cast(dynamic value)
        {
            return new intReader(ref value.Reader>, value.path);
        }
    }
}}}}