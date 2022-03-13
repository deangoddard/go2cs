//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:53:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using token = go.go.token_package;
using filepath = go.path.filepath_package;
using strconv = go.strconv_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class scanner_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Scanner
        {
            // Constructors
            public Scanner(NilType _)
            {
                this.file = default;
                this.dir = default;
                this.src = default;
                this.err = default;
                this.mode = default;
                this.ch = default;
                this.offset = default;
                this.rdOffset = default;
                this.lineOffset = default;
                this.insertSemi = default;
                this.ErrorCount = default;
            }

            public Scanner(ref ptr<token.File> file = default, @string dir = default, slice<byte> src = default, ErrorHandler err = default, Mode mode = default, int ch = default, nint offset = default, nint rdOffset = default, nint lineOffset = default, bool insertSemi = default, nint ErrorCount = default)
            {
                this.file = file;
                this.dir = dir;
                this.src = src;
                this.err = err;
                this.mode = mode;
                this.ch = ch;
                this.offset = offset;
                this.rdOffset = rdOffset;
                this.lineOffset = lineOffset;
                this.insertSemi = insertSemi;
                this.ErrorCount = ErrorCount;
            }

            // Enable comparisons between nil and Scanner struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Scanner value, NilType nil) => value.Equals(default(Scanner));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Scanner value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Scanner value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Scanner value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Scanner(NilType nil) => default(Scanner);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Scanner Scanner_cast(dynamic value)
        {
            return new Scanner(ref value.file, value.dir, value.src, value.err, value.mode, value.ch, value.offset, value.rdOffset, value.lineOffset, value.insertSemi, value.ErrorCount);
        }
    }
}}