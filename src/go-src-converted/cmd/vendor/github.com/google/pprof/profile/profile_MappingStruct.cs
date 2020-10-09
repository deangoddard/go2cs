//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Mapping
        {
            // Constructors
            public Mapping(NilType _)
            {
                this.ID = default;
                this.Start = default;
                this.Limit = default;
                this.Offset = default;
                this.File = default;
                this.BuildID = default;
                this.HasFunctions = default;
                this.HasFilenames = default;
                this.HasLineNumbers = default;
                this.HasInlineFrames = default;
                this.fileX = default;
                this.buildIDX = default;
            }

            public Mapping(ulong ID = default, ulong Start = default, ulong Limit = default, ulong Offset = default, @string File = default, @string BuildID = default, bool HasFunctions = default, bool HasFilenames = default, bool HasLineNumbers = default, bool HasInlineFrames = default, long fileX = default, long buildIDX = default)
            {
                this.ID = ID;
                this.Start = Start;
                this.Limit = Limit;
                this.Offset = Offset;
                this.File = File;
                this.BuildID = BuildID;
                this.HasFunctions = HasFunctions;
                this.HasFilenames = HasFilenames;
                this.HasLineNumbers = HasLineNumbers;
                this.HasInlineFrames = HasInlineFrames;
                this.fileX = fileX;
                this.buildIDX = buildIDX;
            }

            // Enable comparisons between nil and Mapping struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Mapping value, NilType nil) => value.Equals(default(Mapping));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Mapping value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Mapping value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Mapping value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mapping(NilType nil) => default(Mapping);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Mapping Mapping_cast(dynamic value)
        {
            return new Mapping(value.ID, value.Start, value.Limit, value.Offset, value.File, value.BuildID, value.HasFunctions, value.HasFilenames, value.HasLineNumbers, value.HasInlineFrames, value.fileX, value.buildIDX);
        }
    }
}}}}}}