//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:00:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using scanner = go.go.scanner_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using strings = go.strings_package;
using sync = go.sync_package;
using cfg = go.cmd.go.@internal.cfg_package;
using str = go.cmd.go.@internal.str_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class @base_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Command
        {
            // Constructors
            public Command(NilType _)
            {
                this.Run = default;
                this.UsageLine = default;
                this.Short = default;
                this.Long = default;
                this.Flag = default;
                this.CustomFlags = default;
            }

            public Command(Action<ref Command, slice<@string>> Run = default, @string UsageLine = default, @string Short = default, @string Long = default, flag.FlagSet Flag = default, bool CustomFlags = default)
            {
                this.Run = Run;
                this.UsageLine = UsageLine;
                this.Short = Short;
                this.Long = Long;
                this.Flag = Flag;
                this.CustomFlags = CustomFlags;
            }

            // Enable comparisons between nil and Command struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Command value, NilType nil) => value.Equals(default(Command));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Command value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Command value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Command value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Command(NilType nil) => default(Command);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Command Command_cast(dynamic value)
        {
            return new Command(value.Run, value.UsageLine, value.Short, value.Long, value.Flag, value.CustomFlags);
        }
    }
}}}}