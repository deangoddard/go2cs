//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:29:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using reflect = go.reflect_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct pathMode
        {
            // Constructors
            public pathMode(NilType _)
            {
                this.path = default;
                this.mode = default;
            }

            public pathMode(@string path = default, os.FileMode mode = default)
            {
                this.path = path;
                this.mode = mode;
            }

            // Enable comparisons between nil and pathMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pathMode value, NilType nil) => value.Equals(default(pathMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pathMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pathMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pathMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pathMode(NilType nil) => default(pathMode);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static pathMode pathMode_cast(dynamic value)
        {
            return new pathMode(value.path, value.mode);
        }
    }
}