//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using errors = go.errors_package;
using execenv = go.@internal.syscall.execenv_package;
using io = go.io_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using syscall = go.syscall_package;
using go;

#nullable enable

namespace go {
namespace os
{
    public static partial class exec_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Error
        {
            // Constructors
            public Error(NilType _)
            {
                this.Name = default;
                this.Err = default;
            }

            public Error(@string Name = default, error Err = default)
            {
                this.Name = Name;
                this.Err = Err;
            }

            // Enable comparisons between nil and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Error value, NilType nil) => value.Equals(default(Error));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Error value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Error value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Error value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(NilType nil) => default(Error);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Error Error_cast(dynamic value)
        {
            return new Error(value.Name, value.Err);
        }
    }
}}