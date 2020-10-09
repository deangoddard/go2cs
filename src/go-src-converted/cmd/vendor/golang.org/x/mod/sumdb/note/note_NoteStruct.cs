//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using base64 = go.encoding.base64_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using ed25519 = go.golang.org.x.crypto.ed25519_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class note_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Note
        {
            // Constructors
            public Note(NilType _)
            {
                this.Text = default;
                this.Sigs = default;
                this.UnverifiedSigs = default;
            }

            public Note(@string Text = default, slice<Signature> Sigs = default, slice<Signature> UnverifiedSigs = default)
            {
                this.Text = Text;
                this.Sigs = Sigs;
                this.UnverifiedSigs = UnverifiedSigs;
            }

            // Enable comparisons between nil and Note struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Note value, NilType nil) => value.Equals(default(Note));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Note value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Note value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Note value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Note(NilType nil) => default(Note);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Note Note_cast(dynamic value)
        {
            return new Note(value.Text, value.Sigs, value.UnverifiedSigs);
        }
    }
}}}}}}}