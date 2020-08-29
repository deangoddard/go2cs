//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using base64 = go.encoding.base64_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;

namespace go
{
    public static partial class mime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct WordDecoder
        {
            // Constructors
            public WordDecoder(NilType _)
            {
                this.CharsetReader = default;
            }

            public WordDecoder(Func<@string, io.Reader, (io.Reader, error)> CharsetReader = default)
            {
                this.CharsetReader = CharsetReader;
            }

            // Enable comparisons between nil and WordDecoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(WordDecoder value, NilType nil) => value.Equals(default(WordDecoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(WordDecoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, WordDecoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, WordDecoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator WordDecoder(NilType nil) => default(WordDecoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static WordDecoder WordDecoder_cast(dynamic value)
        {
            return new WordDecoder(value.CharsetReader);
        }
    }
}