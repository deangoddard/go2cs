// Code generated by running "go generate" in golang.org/x/text. DO NOT EDIT.

// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package idna -- go2cs converted at 2020 October 09 06:07:37 UTC
// import "vendor/golang.org/x/net/idna" ==> using idna = go.vendor.golang.org.x.net.idna_package
// Original source: C:\Go\src\vendor\golang.org\x\net\idna\trie.go

using static go.builtin;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class idna_package
    {
        // appendMapping appends the mapping for the respective rune. isMapped must be
        // true. A mapping is a categorization of a rune as defined in UTS #46.
        private static slice<byte> appendMapping(this info c, slice<byte> b, @string s)
        {
            var index = int(c >> (int)(indexShift));
            if (c & xorBit == 0L)
            {
                var s = mappings[index..];
                return append(b, s[1L..s[0L] + 1L]);
            }
            b = append(b, s);
            if (c & inlineXOR == inlineXOR)
            { 
                // TODO: support and handle two-byte inline masks
                b[len(b) - 1L] ^= byte(index);

            }
            else
            {
                for (var p = len(b) - int(xorData[index]); p < len(b); p++)
                {
                    index++;
                    b[p] ^= xorData[index];
                }

            }
            return b;

        }

        // Sparse block handling code.

        private partial struct valueRange
        {
            public ushort value; // header: value:stride
            public byte lo; // header: lo:n
            public byte hi; // header: lo:n
        }

        private partial struct sparseBlocks
        {
            public slice<valueRange> values;
            public slice<ushort> offset;
        }

        private static sparseBlocks idnaSparse = new sparseBlocks(values:idnaSparseValues[:],offset:idnaSparseOffset[:],);

        // Don't use newIdnaTrie to avoid unconditional linking in of the table.
        private static ptr<idnaTrie> trie = addr(new idnaTrie());

        // lookup determines the type of block n and looks up the value for b.
        // For n < t.cutoff, the block is a simple lookup table. Otherwise, the block
        // is a list of ranges with an accompanying value. Given a matching range r,
        // the value for b is by r.value + (b - r.lo) * stride.
        private static ushort lookup(this ptr<sparseBlocks> _addr_t, uint n, byte b)
        {
            ref sparseBlocks t = ref _addr_t.val;

            var offset = t.offset[n];
            var header = t.values[offset];
            var lo = offset + 1L;
            var hi = lo + uint16(header.lo);
            while (lo < hi)
            {
                var m = lo + (hi - lo) / 2L;
                var r = t.values[m];
                if (r.lo <= b && b <= r.hi)
                {
                    return r.value + uint16(b - r.lo) * header.value;
                }

                if (b < r.lo)
                {
                    hi = m;
                }
                else
                {
                    lo = m + 1L;
                }

            }

            return 0L;

        }
    }
}}}}}
