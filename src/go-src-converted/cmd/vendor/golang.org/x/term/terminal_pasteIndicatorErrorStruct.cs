//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using io = go.io_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x
{
    public static partial class term_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct pasteIndicatorError
        {
            // Constructors
            public pasteIndicatorError(NilType _)
            {
            }
            // Enable comparisons between nil and pasteIndicatorError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pasteIndicatorError value, NilType nil) => value.Equals(default(pasteIndicatorError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pasteIndicatorError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pasteIndicatorError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pasteIndicatorError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pasteIndicatorError(NilType nil) => default(pasteIndicatorError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static pasteIndicatorError pasteIndicatorError_cast(dynamic value)
        {
            return new pasteIndicatorError();
        }
    }
}}}}}