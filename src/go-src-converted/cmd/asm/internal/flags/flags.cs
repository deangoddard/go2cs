// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package flags implements top-level flags and the usage message for the assembler.
// package flags -- go2cs converted at 2020 August 29 08:48:48 UTC
// import "cmd/asm/internal/flags" ==> using flags = go.cmd.asm.@internal.flags_package
// Original source: C:\Go\src\cmd\asm\internal\flags\flags.go
using objabi = go.cmd.@internal.objabi_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace asm {
namespace @internal
{
    public static partial class flags_package
    {
        public static var Debug = flag.Bool("debug", false, "dump instructions as they are parsed");        public static var OutputFile = flag.String("o", "", "output file; default foo.o for /a/b/c/foo.s as first argument");        public static var PrintOut = flag.Bool("S", false, "print assembly and machine code");        public static var TrimPath = flag.String("trimpath", "", "remove prefix from recorded source file paths");        public static var Shared = flag.Bool("shared", false, "generate code that can be linked into a shared library");        public static var Dynlink = flag.Bool("dynlink", false, "support references to Go symbols defined in other shared libraries");        public static var AllErrors = flag.Bool("e", false, "no limit on number of errors reported");

        public static MultiFlag D = default;        public static MultiFlag I = default;

        private static void init()
        {
            flag.Var(ref D, "D", "predefined symbol with optional simple value -D=identifier=value; can be set multiple times");
            flag.Var(ref I, "I", "include directory; can be set multiple times");
            objabi.AddVersionFlag(); // -V
        }

        // MultiFlag allows setting a value multiple times to collect a list, as in -I=dir1 -I=dir2.
        public partial struct MultiFlag // : slice<@string>
        {
        }

        private static @string String(this ref MultiFlag m)
        {
            if (len(m.Value) == 0L)
            {
                return "";
            }
            return fmt.Sprint(m.Value);
        }

        private static error Set(this ref MultiFlag m, @string val)
        {
            (m.Value) = append(m.Value, val);
            return error.As(null);
        }

        public static void Usage()
        {
            fmt.Fprintf(os.Stderr, "usage: asm [options] file.s ...\n");
            fmt.Fprintf(os.Stderr, "Flags:\n");
            flag.PrintDefaults();
            os.Exit(2L);
        }

        public static void Parse()
        {
            flag.Usage = Usage;
            flag.Parse();
            if (flag.NArg() == 0L)
            {
                flag.Usage();
            } 

            // Flag refinement.
            if (OutputFile == "".Value)
            {
                if (flag.NArg() != 1L)
                {
                    flag.Usage();
                }
                var input = filepath.Base(flag.Arg(0L));
                if (strings.HasSuffix(input, ".s"))
                {
                    input = input[..len(input) - 2L];
                }
                OutputFile.Value = fmt.Sprintf("%s.o", input);
            }
        }
    }
}}}}
