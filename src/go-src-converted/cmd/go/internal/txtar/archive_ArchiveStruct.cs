//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:48:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class txtar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Archive
        {
            // Constructors
            public Archive(NilType _)
            {
                this.Comment = default;
                this.Files = default;
            }

            public Archive(slice<byte> Comment = default, slice<File> Files = default)
            {
                this.Comment = Comment;
                this.Files = Files;
            }

            // Enable comparisons between nil and Archive struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Archive value, NilType nil) => value.Equals(default(Archive));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Archive value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Archive value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Archive value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Archive(NilType nil) => default(Archive);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Archive Archive_cast(dynamic value)
        {
            return new Archive(value.Comment, value.Files);
        }
    }
}}}}