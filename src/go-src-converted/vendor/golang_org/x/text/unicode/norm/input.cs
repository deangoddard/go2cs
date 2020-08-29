// Code generated by running "go generate" in golang.org/x/text. DO NOT EDIT.

// Copyright 2011 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package norm -- go2cs converted at 2020 August 29 10:13:03 UTC
// import "vendor/golang_org/x/text/unicode/norm" ==> using norm = go.vendor.golang_org.x.text.unicode.norm_package
// Original source: C:\Go\src\vendor\golang_org\x\text\unicode\norm\input.go
using utf8 = go.unicode.utf8_package;
using static go.builtin;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class norm_package
    {
        private partial struct input
        {
            public @string str;
            public slice<byte> bytes;
        }

        private static input inputBytes(slice<byte> str)
        {
            return new input(bytes:str);
        }

        private static input inputString(@string str)
        {
            return new input(str:str);
        }

        private static void setBytes(this ref input @in, slice<byte> str)
        {
            @in.str = "";
            @in.bytes = str;
        }

        private static void setString(this ref input @in, @string str)
        {
            @in.str = str;
            @in.bytes = null;
        }

        private static byte _byte(this ref input @in, long p)
        {
            if (@in.bytes == null)
            {
                return @in.str[p];
            }
            return @in.bytes[p];
        }

        private static long skipASCII(this ref input @in, long p, long max)
        {
            if (@in.bytes == null)
            {
                while (p < max && @in.str[p] < utf8.RuneSelf)
                {
                    p++;
                }
            else

            }            {
                while (p < max && @in.bytes[p] < utf8.RuneSelf)
                {
                    p++;
                }

            }
            return p;
        }

        private static long skipContinuationBytes(this ref input @in, long p)
        {
            if (@in.bytes == null)
            {
                while (p < len(@in.str) && !utf8.RuneStart(@in.str[p]))
                {
                    p++;
                }
            else

            }            {
                while (p < len(@in.bytes) && !utf8.RuneStart(@in.bytes[p]))
                {
                    p++;
                }

            }
            return p;
        }

        private static slice<byte> appendSlice(this ref input @in, slice<byte> buf, long b, long e)
        {
            if (@in.bytes != null)
            {
                return append(buf, @in.bytes[b..e]);
            }
            for (var i = b; i < e; i++)
            {
                buf = append(buf, @in.str[i]);
            }

            return buf;
        }

        private static long copySlice(this ref input @in, slice<byte> buf, long b, long e)
        {
            if (@in.bytes == null)
            {
                return copy(buf, @in.str[b..e]);
            }
            return copy(buf, @in.bytes[b..e]);
        }

        private static (ushort, long) charinfoNFC(this ref input @in, long p)
        {
            if (@in.bytes == null)
            {
                return nfcData.lookupString(@in.str[p..]);
            }
            return nfcData.lookup(@in.bytes[p..]);
        }

        private static (ushort, long) charinfoNFKC(this ref input @in, long p)
        {
            if (@in.bytes == null)
            {
                return nfkcData.lookupString(@in.str[p..]);
            }
            return nfkcData.lookup(@in.bytes[p..]);
        }

        private static int hangul(this ref input @in, long p)
        {
            long size = default;
            if (@in.bytes == null)
            {
                if (!isHangulString(@in.str[p..]))
                {
                    return 0L;
                }
                r, size = utf8.DecodeRuneInString(@in.str[p..]);
            }
            else
            {
                if (!isHangul(@in.bytes[p..]))
                {
                    return 0L;
                }
                r, size = utf8.DecodeRune(@in.bytes[p..]);
            }
            if (size != hangulUTF8Size)
            {
                return 0L;
            }
            return r;
        }
    }
}}}}}}
