// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// TODO(gri): This file and the file src/go/format/internal.go are
// the same (but for this comment and the package name). Do not modify
// one without the other. Determine if we can factor out functionality
// in a public API. See also #11844 for context.

// package main -- go2cs converted at 2020 October 09 05:48:08 UTC
// Original source: C:\Go\src\cmd\gofmt\internal.go
using bytes = go.bytes_package;
using ast = go.go.ast_package;
using parser = go.go.parser_package;
using printer = go.go.printer_package;
using token = go.go.token_package;
using strings = go.strings_package;
using static go.builtin;
using System;

namespace go
{
    public static partial class main_package
    {
        // parse parses src, which was read from the named file,
        // as a Go source file, declaration, or statement list.
        private static (ptr<ast.File>, Func<slice<byte>, long, slice<byte>>, long, error) parse(ptr<token.FileSet> _addr_fset, @string filename, slice<byte> src, bool fragmentOk)
        {
            ptr<ast.File> file = default!;
            Func<slice<byte>, long, slice<byte>> sourceAdj = default;
            long indentAdj = default;
            error err = default!;
            ref token.FileSet fset = ref _addr_fset.val;
 
            // Try as whole source file.
            file, err = parser.ParseFile(fset, filename, src, parserMode); 
            // If there's no error, return. If the error is that the source file didn't begin with a
            // package line and source fragments are ok, fall through to
            // try as a source fragment. Stop and return on any other error.
            if (err == null || !fragmentOk || !strings.Contains(err.Error(), "expected 'package'"))
            {
                return ;
            }
            var psrc = append((slice<byte>)"package p;", src);
            file, err = parser.ParseFile(fset, filename, psrc, parserMode);
            if (err == null)
            {
                sourceAdj = (src, indent) =>
                { 
                    // Remove the package clause.
                    // Gofmt has turned the ';' into a '\n'.
                    src = src[indent + len("package p\n")..];
                    return _addr_bytes.TrimSpace(src)!;

                };
                return ;

            }
            if (!strings.Contains(err.Error(), "expected declaration"))
            {
                return ;
            }
            var fsrc = append(append((slice<byte>)"package p; func _() {", src), '\n', '\n', '}');
            file, err = parser.ParseFile(fset, filename, fsrc, parserMode);
            if (err == null)
            {
                sourceAdj = (src, indent) =>
                { 
                    // Cap adjusted indent to zero.
                    if (indent < 0L)
                    {
                        indent = 0L;
                    }
                    src = src[2L * indent + len("package p\n\nfunc _() {")..]; 
                    // Remove only the "}\n" suffix: remaining whitespaces will be trimmed anyway
                    src = src[..len(src) - len("}\n")];
                    return _addr_bytes.TrimSpace(src)!;

                }; 
                // Gofmt has also indented the function body one level.
                // Adjust that with indentAdj.
                indentAdj = -1L;

            }
            return ;

        }

        // format formats the given package file originally obtained from src
        // and adjusts the result based on the original source via sourceAdj
        // and indentAdj.
        private static (slice<byte>, error) format(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_file, Func<slice<byte>, long, slice<byte>> sourceAdj, long indentAdj, slice<byte> src, printer.Config cfg)
        {
            slice<byte> _p0 = default;
            error _p0 = default!;
            ref token.FileSet fset = ref _addr_fset.val;
            ref ast.File file = ref _addr_file.val;

            if (sourceAdj == null)
            { 
                // Complete source file.
                ref bytes.Buffer buf = ref heap(out ptr<bytes.Buffer> _addr_buf);
                var err = cfg.Fprint(_addr_buf, fset, file);
                if (err != null)
                {
                    return (null, error.As(err)!);
                }

                return (buf.Bytes(), error.As(null!)!);

            } 

            // Partial source file.
            // Determine and prepend leading space.
            long i = 0L;
            long j = 0L;
            while (j < len(src) && isSpace(src[j]))
            {
                if (src[j] == '\n')
                {
                    i = j + 1L; // byte offset of last line in leading space
                }

                j++;

            }

            slice<byte> res = default;
            res = append(res, src[..i]); 

            // Determine and prepend indentation of first code line.
            // Spaces are ignored unless there are no tabs,
            // in which case spaces count as one tab.
            long indent = 0L;
            var hasSpace = false;
            foreach (var (_, b) in src[i..j])
            {
                switch (b)
                {
                    case ' ': 
                        hasSpace = true;
                        break;
                    case '\t': 
                        indent++;
                        break;
                }

            }
            if (indent == 0L && hasSpace)
            {
                indent = 1L;
            }

            {
                long i__prev1 = i;

                for (i = 0L; i < indent; i++)
                {
                    res = append(res, '\t');
                } 

                // Format the source.
                // Write it without any leading and trailing space.


                i = i__prev1;
            } 

            // Format the source.
            // Write it without any leading and trailing space.
            cfg.Indent = indent + indentAdj;
            buf = default;
            err = cfg.Fprint(_addr_buf, fset, file);
            if (err != null)
            {
                return (null, error.As(err)!);
            }

            var @out = sourceAdj(buf.Bytes(), cfg.Indent); 

            // If the adjusted output is empty, the source
            // was empty but (possibly) for white space.
            // The result is the incoming source.
            if (len(out) == 0L)
            {
                return (src, error.As(null!)!);
            } 

            // Otherwise, append output to leading space.
            res = append(res, out); 

            // Determine and append trailing space.
            i = len(src);
            while (i > 0L && isSpace(src[i - 1L]))
            {
                i--;
            }

            return (append(res, src[i..]), error.As(null!)!);

        }

        // isSpace reports whether the byte is a space character.
        // isSpace defines a space as being among the following bytes: ' ', '\t', '\n' and '\r'.
        private static bool isSpace(byte b)
        {
            return b == ' ' || b == '\t' || b == '\n' || b == '\r';
        }
    }
}
