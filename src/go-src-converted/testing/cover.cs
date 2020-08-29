// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Support for test coverage.

// package testing -- go2cs converted at 2020 August 29 10:05:49 UTC
// import "testing" ==> using testing = go.testing_package
// Original source: C:\Go\src\testing\cover.go
using fmt = go.fmt_package;
using os = go.os_package;
using atomic = go.sync.atomic_package;
using static go.builtin;
using System;

namespace go
{
    public static partial class testing_package
    {
        // CoverBlock records the coverage data for a single basic block.
        // NOTE: This struct is internal to the testing infrastructure and may change.
        // It is not covered (yet) by the Go 1 compatibility guidelines.
        public partial struct CoverBlock
        {
            public uint Line0;
            public ushort Col0;
            public uint Line1;
            public ushort Col1;
            public ushort Stmts;
        }

        private static Cover cover = default;

        // Cover records information about test coverage checking.
        // NOTE: This struct is internal to the testing infrastructure and may change.
        // It is not covered (yet) by the Go 1 compatibility guidelines.
        public partial struct Cover
        {
            public @string Mode;
            public map<@string, slice<uint>> Counters;
            public map<@string, slice<CoverBlock>> Blocks;
            public @string CoveredPackages;
        }

        // Coverage reports the current code coverage as a fraction in the range [0, 1].
        // If coverage is not enabled, Coverage returns 0.
        //
        // When running a large set of sequential test cases, checking Coverage after each one
        // can be useful for identifying which test cases exercise new code paths.
        // It is not a replacement for the reports generated by 'go test -cover' and
        // 'go tool cover'.
        public static double Coverage()
        {
            long n = default;            long d = default;

            foreach (var (_, counters) in cover.Counters)
            {
                foreach (var (i) in counters)
                {
                    if (atomic.LoadUint32(ref counters[i]) > 0L)
                    {
                        n++;
                    }
                    d++;
                }
            }
            if (d == 0L)
            {
                return 0L;
            }
            return float64(n) / float64(d);
        }

        // RegisterCover records the coverage data accumulators for the tests.
        // NOTE: This function is internal to the testing infrastructure and may change.
        // It is not covered (yet) by the Go 1 compatibility guidelines.
        public static void RegisterCover(Cover c)
        {
            cover = c;
        }

        // mustBeNil checks the error and, if present, reports it and exits.
        private static void mustBeNil(error err)
        {
            if (err != null)
            {
                fmt.Fprintf(os.Stderr, "testing: %s\n", err);
                os.Exit(2L);
            }
        }

        // coverReport reports the coverage percentage and writes a coverage profile if requested.
        private static void coverReport() => func((defer, _, __) =>
        {
            ref os.File f = default;
            error err = default;
            if (coverProfile != "".Value)
            {
                f, err = os.Create(toOutputDir(coverProfile.Value));
                mustBeNil(err);
                fmt.Fprintf(f, "mode: %s\n", cover.Mode);
                defer(() =>
                {
                    mustBeNil(f.Close());

                }());
            }
            long active = default;            long total = default;

            uint count = default;
            foreach (var (name, counts) in cover.Counters)
            {
                var blocks = cover.Blocks[name];
                foreach (var (i) in counts)
                {
                    var stmts = int64(blocks[i].Stmts);
                    total += stmts;
                    count = atomic.LoadUint32(ref counts[i]); // For -mode=atomic.
                    if (count > 0L)
                    {
                        active += stmts;
                    }
                    if (f != null)
                    {
                        var (_, err) = fmt.Fprintf(f, "%s:%d.%d,%d.%d %d %d\n", name, blocks[i].Line0, blocks[i].Col0, blocks[i].Line1, blocks[i].Col1, stmts, count);
                        mustBeNil(err);
                    }
                }
            }
            if (total == 0L)
            {
                total = 1L;
            }
            fmt.Printf("coverage: %.1f%% of statements%s\n", 100L * float64(active) / float64(total), cover.CoveredPackages);
        });
    }
}
