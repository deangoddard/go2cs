//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using math = go.math_package;
using os = go.os_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools
{
    public static partial class cover_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Profile
        {
            // Constructors
            public Profile(NilType _)
            {
                this.FileName = default;
                this.Mode = default;
                this.Blocks = default;
            }

            public Profile(@string FileName = default, @string Mode = default, slice<ProfileBlock> Blocks = default)
            {
                this.FileName = FileName;
                this.Mode = Mode;
                this.Blocks = Blocks;
            }

            // Enable comparisons between nil and Profile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Profile value, NilType nil) => value.Equals(default(Profile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Profile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Profile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Profile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Profile(NilType nil) => default(Profile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Profile Profile_cast(dynamic value)
        {
            return new Profile(value.FileName, value.Mode, value.Blocks);
        }
    }
}}}}}}