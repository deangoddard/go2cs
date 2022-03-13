//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct sparseFileReader
        {
            // Constructors
            public sparseFileReader(NilType _)
            {
                this.fr = default;
                this.sp = default;
                this.pos = default;
            }

            public sparseFileReader(fileReader fr = default, sparseHoles sp = default, long pos = default)
            {
                this.fr = fr;
                this.sp = sp;
                this.pos = pos;
            }

            // Enable comparisons between nil and sparseFileReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sparseFileReader value, NilType nil) => value.Equals(default(sparseFileReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sparseFileReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sparseFileReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sparseFileReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sparseFileReader(NilType nil) => default(sparseFileReader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static sparseFileReader sparseFileReader_cast(dynamic value)
        {
            return new sparseFileReader(value.fr, value.sp, value.pos);
        }
    }
}}