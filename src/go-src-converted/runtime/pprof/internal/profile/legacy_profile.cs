// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// This file implements parsers to convert legacy profiles into the
// profile.proto format.

// package profile -- go2cs converted at 2020 August 29 08:24:16 UTC
// import "runtime/pprof/internal/profile" ==> using profile = go.runtime.pprof.@internal.profile_package
// Original source: C:\Go\src\runtime\pprof\internal\profile\legacy_profile.go
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using regexp = go.regexp_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using static go.builtin;
using System;

namespace go {
namespace runtime {
namespace pprof {
namespace @internal
{
    public static partial class profile_package
    {
        private static var countStartRE = regexp.MustCompile("\\A(\\w+) profile: total \\d+\\n\\z");        private static var countRE = regexp.MustCompile("\\A(\\d+) @(( 0x[0-9a-f]+)+)\\n\\z");        private static var heapHeaderRE = regexp.MustCompile("heap profile: *(\\d+): *(\\d+) *\\[ *(\\d+): *(\\d+) *\\] *@ *(heap[_a-z0-9]*)/?(\\d*)");        private static var heapSampleRE = regexp.MustCompile("(-?\\d+): *(-?\\d+) *\\[ *(\\d+): *(\\d+) *] @([ x0-9a-f]*)");        private static var contentionSampleRE = regexp.MustCompile("(\\d+) *(\\d+) @([ x0-9a-f]*)");        private static var hexNumberRE = regexp.MustCompile("0x[0-9a-f]+");        private static var growthHeaderRE = regexp.MustCompile("heap profile: *(\\d+): *(\\d+) *\\[ *(\\d+): *(\\d+) *\\] @ growthz");        private static var fragmentationHeaderRE = regexp.MustCompile("heap profile: *(\\d+): *(\\d+) *\\[ *(\\d+): *(\\d+) *\\] @ fragmentationz");        private static var threadzStartRE = regexp.MustCompile("--- threadz \\d+ ---");        private static var threadStartRE = regexp.MustCompile("--- Thread ([[:xdigit:]]+) \\(name: (.*)/(\\d+)\\) stack: ---");        private static var procMapsRE = regexp.MustCompile("([[:xdigit:]]+)-([[:xdigit:]]+)\\s+([-rwxp]+)\\s+([[:xdigit:]]+)\\s+([[:xdigit:]]+):" +
    "([[:xdigit:]]+)\\s+([[:digit:]]+)\\s*(\\S+)?");        private static var briefMapsRE = regexp.MustCompile("\\s*([[:xdigit:]]+)-([[:xdigit:]]+):\\s*(\\S+)(\\s.*@)?([[:xdigit:]]+)?");        public static bool LegacyHeapAllocated = default;

        private static bool isSpaceOrComment(@string line)
        {
            var trimmed = strings.TrimSpace(line);
            return len(trimmed) == 0L || trimmed[0L] == '#';
        }

        // parseGoCount parses a Go count profile (e.g., threadcreate or
        // goroutine) and returns a new Profile.
        private static (ref Profile, error) parseGoCount(slice<byte> b)
        {
            var r = bytes.NewBuffer(b);

            @string line = default;
            error err = default;
            while (true)
            { 
                // Skip past comments and empty lines seeking a real header.
                line, err = r.ReadString('\n');
                if (err != null)
                {
                    return (null, err);
                }
                if (!isSpaceOrComment(line))
                {
                    break;
                }
            }


            var m = countStartRE.FindStringSubmatch(line);
            if (m == null)
            {
                return (null, errUnrecognized);
            }
            var profileType = m[1L];
            Profile p = ref new Profile(PeriodType:&ValueType{Type:profileType,Unit:"count"},Period:1,SampleType:[]*ValueType{{Type:profileType,Unit:"count"}},);
            var locations = make_map<ulong, ref Location>();
            while (true)
            {
                line, err = r.ReadString('\n');
                if (err != null)
                {
                    if (err == io.EOF)
                    {
                        break;
                    }
                    return (null, err);
                }
                if (isSpaceOrComment(line))
                {
                    continue;
                }
                if (strings.HasPrefix(line, "---"))
                {
                    break;
                }
                m = countRE.FindStringSubmatch(line);
                if (m == null)
                {
                    return (null, errMalformed);
                }
                var (n, err) = strconv.ParseInt(m[1L], 0L, 64L);
                if (err != null)
                {
                    return (null, errMalformed);
                }
                var fields = strings.Fields(m[2L]);
                var locs = make_slice<ref Location>(0L, len(fields));
                foreach (var (_, stk) in fields)
                {
                    var (addr, err) = strconv.ParseUint(stk, 0L, 64L);
                    if (err != null)
                    {
                        return (null, errMalformed);
                    } 
                    // Adjust all frames by -1 to land on the call instruction.
                    addr--;
                    var loc = locations[addr];
                    if (loc == null)
                    {
                        loc = ref new Location(Address:addr,);
                        locations[addr] = loc;
                        p.Location = append(p.Location, loc);
                    }
                    locs = append(locs, loc);
                }
                p.Sample = append(p.Sample, ref new Sample(Location:locs,Value:[]int64{n},));
            }


            err = error.As(parseAdditionalSections(strings.TrimSpace(line), r, p));

            if (err != null)
            {
                return (null, err);
            }
            return (p, null);
        }

        // remapLocationIDs ensures there is a location for each address
        // referenced by a sample, and remaps the samples to point to the new
        // location ids.
        private static void remapLocationIDs(this ref Profile p)
        {
            var seen = make_map<ref Location, bool>(len(p.Location));
            slice<ref Location> locs = default;

            foreach (var (_, s) in p.Sample)
            {
                foreach (var (_, l) in s.Location)
                {
                    if (seen[l])
                    {
                        continue;
                    }
                    l.ID = uint64(len(locs) + 1L);
                    locs = append(locs, l);
                    seen[l] = true;
                }
            }
            p.Location = locs;
        }

        private static void remapFunctionIDs(this ref Profile p)
        {
            var seen = make_map<ref Function, bool>(len(p.Function));
            slice<ref Function> fns = default;

            foreach (var (_, l) in p.Location)
            {
                foreach (var (_, ln) in l.Line)
                {
                    var fn = ln.Function;
                    if (fn == null || seen[fn])
                    {
                        continue;
                    }
                    fn.ID = uint64(len(fns) + 1L);
                    fns = append(fns, fn);
                    seen[fn] = true;
                }
            }
            p.Function = fns;
        }

        // remapMappingIDs matches location addresses with existing mappings
        // and updates them appropriately. This is O(N*M), if this ever shows
        // up as a bottleneck, evaluate sorting the mappings and doing a
        // binary search, which would make it O(N*log(M)).
        private static void remapMappingIDs(this ref Profile p)
        {
            if (len(p.Mapping) == 0L)
            {
                return;
            } 

            // Some profile handlers will incorrectly set regions for the main
            // executable if its section is remapped. Fix them through heuristics.

            // Remove the initial mapping if named '/anon_hugepage' and has a
            // consecutive adjacent mapping.
            {
                var m__prev1 = m;

                var m = p.Mapping[0L];

                if (strings.HasPrefix(m.File, "/anon_hugepage"))
                {
                    if (len(p.Mapping) > 1L && m.Limit == p.Mapping[1L].Start)
                    {
                        p.Mapping = p.Mapping[1L..];
                    }
                } 

                // Subtract the offset from the start of the main mapping if it
                // ends up at a recognizable start address.

                m = m__prev1;

            } 

            // Subtract the offset from the start of the main mapping if it
            // ends up at a recognizable start address.
            const ulong expectedStart = 0x400000UL;

            {
                var m__prev1 = m;

                m = p.Mapping[0L];

                if (m.Start - m.Offset == expectedStart)
                {
                    m.Start = expectedStart;
                    m.Offset = 0L;
                }

                m = m__prev1;

            }

            foreach (var (_, l) in p.Location)
            {
                {
                    var a = l.Address;

                    if (a != 0L)
                    {
                        {
                            var m__prev2 = m;

                            foreach (var (_, __m) in p.Mapping)
                            {
                                m = __m;
                                if (m.Start <= a && a < m.Limit)
                                {
                                    l.Mapping = m;
                                    break;
                                }
                            }

                            m = m__prev2;
                        }

                    }

                }
            } 

            // Reset all mapping IDs.
            {
                var m__prev1 = m;

                foreach (var (__i, __m) in p.Mapping)
                {
                    i = __i;
                    m = __m;
                    m.ID = uint64(i + 1L);
                }

                m = m__prev1;
            }

        }

        private static Func<slice<byte>, (ulong, slice<byte>)> cpuInts = new slice<Func<slice<byte>, (ulong, slice<byte>)>>(new Func<slice<byte>, (ulong, slice<byte>)>[] { get32l, get32b, get64l, get64b });

        private static (ulong, slice<byte>) get32l(slice<byte> b)
        {
            if (len(b) < 4L)
            {
                return (0L, null);
            }
            return (uint64(b[0L]) | uint64(b[1L]) << (int)(8L) | uint64(b[2L]) << (int)(16L) | uint64(b[3L]) << (int)(24L), b[4L..]);
        }

        private static (ulong, slice<byte>) get32b(slice<byte> b)
        {
            if (len(b) < 4L)
            {
                return (0L, null);
            }
            return (uint64(b[3L]) | uint64(b[2L]) << (int)(8L) | uint64(b[1L]) << (int)(16L) | uint64(b[0L]) << (int)(24L), b[4L..]);
        }

        private static (ulong, slice<byte>) get64l(slice<byte> b)
        {
            if (len(b) < 8L)
            {
                return (0L, null);
            }
            return (uint64(b[0L]) | uint64(b[1L]) << (int)(8L) | uint64(b[2L]) << (int)(16L) | uint64(b[3L]) << (int)(24L) | uint64(b[4L]) << (int)(32L) | uint64(b[5L]) << (int)(40L) | uint64(b[6L]) << (int)(48L) | uint64(b[7L]) << (int)(56L), b[8L..]);
        }

        private static (ulong, slice<byte>) get64b(slice<byte> b)
        {
            if (len(b) < 8L)
            {
                return (0L, null);
            }
            return (uint64(b[7L]) | uint64(b[6L]) << (int)(8L) | uint64(b[5L]) << (int)(16L) | uint64(b[4L]) << (int)(24L) | uint64(b[3L]) << (int)(32L) | uint64(b[2L]) << (int)(40L) | uint64(b[1L]) << (int)(48L) | uint64(b[0L]) << (int)(56L), b[8L..]);
        }

        // ParseTracebacks parses a set of tracebacks and returns a newly
        // populated profile. It will accept any text file and generate a
        // Profile out of it with any hex addresses it can identify, including
        // a process map if it can recognize one. Each sample will include a
        // tag "source" with the addresses recognized in string format.
        public static (ref Profile, error) ParseTracebacks(slice<byte> b)
        {
            var r = bytes.NewBuffer(b);

            Profile p = ref new Profile(PeriodType:&ValueType{Type:"trace",Unit:"count"},Period:1,SampleType:[]*ValueType{{Type:"trace",Unit:"count"},},);

            slice<@string> sources = default;
            slice<ref Location> sloc = default;

            var locs = make_map<ulong, ref Location>();
            while (true)
            {
                var (l, err) = r.ReadString('\n');
                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return (null, err);
                    }
                    if (l == "")
                    {
                        break;
                    }
                }
                if (sectionTrigger(l) == memoryMapSection)
                {
                    break;
                }
                {
                    var (s, addrs) = extractHexAddresses(l);

                    if (len(s) > 0L)
                    {
                        foreach (var (_, addr) in addrs)
                        { 
                            // Addresses from stack traces point to the next instruction after
                            // each call. Adjust by -1 to land somewhere on the actual call.
                            addr--;
                            var loc = locs[addr];
                            if (locs[addr] == null)
                            {
                                loc = ref new Location(Address:addr,);
                                p.Location = append(p.Location, loc);
                                locs[addr] = loc;
                            }
                            sloc = append(sloc, loc);
                        }
                    else

                        sources = append(sources, s);
                    }                    {
                        if (len(sources) > 0L || len(sloc) > 0L)
                        {
                            addTracebackSample(sloc, sources, p);
                            sloc = null;
                            sources = null;
                        }
                    }

                }
            } 

            // Add final sample to save any leftover data.
 

            // Add final sample to save any leftover data.
            if (len(sources) > 0L || len(sloc) > 0L)
            {
                addTracebackSample(sloc, sources, p);
            }
            {
                var err = p.ParseMemoryMap(r);

                if (err != null)
                {
                    return (null, err);
                }

            }
            return (p, null);
        }

        private static void addTracebackSample(slice<ref Location> l, slice<@string> s, ref Profile p)
        {
            p.Sample = append(p.Sample, ref new Sample(Value:[]int64{1},Location:l,Label:map[string][]string{"source":s},));
        }

        // parseCPU parses a profilez legacy profile and returns a newly
        // populated Profile.
        //
        // The general format for profilez samples is a sequence of words in
        // binary format. The first words are a header with the following data:
        //   1st word -- 0
        //   2nd word -- 3
        //   3rd word -- 0 if a c++ application, 1 if a java application.
        //   4th word -- Sampling period (in microseconds).
        //   5th word -- Padding.
        private static (ref Profile, error) parseCPU(slice<byte> b)
        {
            Func<slice<byte>, (ulong, slice<byte>)> parse = default;
            ulong n1 = default;            ulong n2 = default;            ulong n3 = default;            ulong n4 = default;            ulong n5 = default;

            foreach (var (_, __parse) in cpuInts)
            {
                parse = __parse;
                slice<byte> tmp = default;
                n1, tmp = parse(b);
                n2, tmp = parse(tmp);
                n3, tmp = parse(tmp);
                n4, tmp = parse(tmp);
                n5, tmp = parse(tmp);

                if (tmp != null && n1 == 0L && n2 == 3L && n3 == 0L && n4 > 0L && n5 == 0L)
                {
                    b = tmp;
                    return cpuProfile(b, int64(n4), parse);
                }
            }

            return (null, errUnrecognized);
        }

        // cpuProfile returns a new Profile from C++ profilez data.
        // b is the profile bytes after the header, period is the profiling
        // period, and parse is a function to parse 8-byte chunks from the
        // profile in its native endianness.
        private static (ref Profile, error) cpuProfile(slice<byte> b, long period, Func<slice<byte>, (ulong, slice<byte>)> parse)
        {
            Profile p = ref new Profile(Period:period*1000,PeriodType:&ValueType{Type:"cpu",Unit:"nanoseconds"},SampleType:[]*ValueType{{Type:"samples",Unit:"count"},{Type:"cpu",Unit:"nanoseconds"},},);
            error err = default;
            b, _, err = parseCPUSamples(b, parse, true, p);

            if (err != null)
            {
                return (null, err);
            } 

            // If all samples have the same second-to-the-bottom frame, it
            // strongly suggests that it is an uninteresting artifact of
            // measurement -- a stack frame pushed by the signal handler. The
            // bottom frame is always correct as it is picked up from the signal
            // structure, not the stack. Check if this is the case and if so,
            // remove.
            if (len(p.Sample) > 1L && len(p.Sample[0L].Location) > 1L)
            {
                var allSame = true;
                var id1 = p.Sample[0L].Location[1L].Address;
                {
                    var s__prev1 = s;

                    foreach (var (_, __s) in p.Sample)
                    {
                        s = __s;
                        if (len(s.Location) < 2L || id1 != s.Location[1L].Address)
                        {
                            allSame = false;
                            break;
                        }
                    }

                    s = s__prev1;
                }

                if (allSame)
                {
                    {
                        var s__prev1 = s;

                        foreach (var (_, __s) in p.Sample)
                        {
                            s = __s;
                            s.Location = append(s.Location[..1L], s.Location[2L..]);
                        }

                        s = s__prev1;
                    }

                }
            }
            {
                error err__prev1 = err;

                err = p.ParseMemoryMap(bytes.NewBuffer(b));

                if (err != null)
                {
                    return (null, err);
                }

                err = err__prev1;

            }
            return (p, null);
        }

        // parseCPUSamples parses a collection of profilez samples from a
        // profile.
        //
        // profilez samples are a repeated sequence of stack frames of the
        // form:
        //    1st word -- The number of times this stack was encountered.
        //    2nd word -- The size of the stack (StackSize).
        //    3rd word -- The first address on the stack.
        //    ...
        //    StackSize + 2 -- The last address on the stack
        // The last stack trace is of the form:
        //   1st word -- 0
        //   2nd word -- 1
        //   3rd word -- 0
        //
        // Addresses from stack traces may point to the next instruction after
        // each call. Optionally adjust by -1 to land somewhere on the actual
        // call (except for the leaf, which is not a call).
        private static (slice<byte>, map<ulong, ref Location>, error) parseCPUSamples(slice<byte> b, Func<slice<byte>, (ulong, slice<byte>)> parse, bool adjust, ref Profile p)
        {
            var locs = make_map<ulong, ref Location>();
            while (len(b) > 0L)
            {
                ulong count = default;                ulong nstk = default;

                count, b = parse(b);
                nstk, b = parse(b);
                if (b == null || nstk > uint64(len(b) / 4L))
                {
                    return (null, null, errUnrecognized);
                }
                slice<ref Location> sloc = default;
                var addrs = make_slice<ulong>(nstk);
                {
                    long i__prev2 = i;

                    for (long i = 0L; i < int(nstk); i++)
                    {
                        addrs[i], b = parse(b);
                    }


                    i = i__prev2;
                }

                if (count == 0L && nstk == 1L && addrs[0L] == 0L)
                { 
                    // End of data marker
                    break;
                }
                {
                    long i__prev2 = i;

                    foreach (var (__i, __addr) in addrs)
                    {
                        i = __i;
                        addr = __addr;
                        if (adjust && i > 0L)
                        {
                            addr--;
                        }
                        var loc = locs[addr];
                        if (loc == null)
                        {
                            loc = ref new Location(Address:addr,);
                            locs[addr] = loc;
                            p.Location = append(p.Location, loc);
                        }
                        sloc = append(sloc, loc);
                    }

                    i = i__prev2;
                }

                p.Sample = append(p.Sample, ref new Sample(Value:[]int64{int64(count),int64(count)*p.Period},Location:sloc,));
            } 
            // Reached the end without finding the EOD marker.
 
            // Reached the end without finding the EOD marker.
            return (b, locs, null);
        }

        // parseHeap parses a heapz legacy or a growthz profile and
        // returns a newly populated Profile.
        private static (ref Profile, error) parseHeap(slice<byte> b)
        {
            var r = bytes.NewBuffer(b);
            var (l, err) = r.ReadString('\n');
            if (err != null)
            {
                return (null, errUnrecognized);
            }
            @string sampling = "";

            {
                var header = heapHeaderRE.FindStringSubmatch(l);

                if (header != null)
                {
                    p = ref new Profile(SampleType:[]*ValueType{{Type:"objects",Unit:"count"},{Type:"space",Unit:"bytes"},},PeriodType:&ValueType{Type:"objects",Unit:"bytes"},);

                    long period = default;
                    if (len(header[6L]) > 0L)
                    {
                        period, err = strconv.ParseInt(header[6L], 10L, 64L);

                        if (err != null)
                        {
                            return (null, errUnrecognized);
                        }
                    }
                    switch (header[5L])
                    {
                        case "heapz_v2": 

                        case "heap_v2": 
                            sampling = "v2";
                            p.Period = period;
                            break;
                        case "heapprofile": 
                            sampling = "";
                            p.Period = 1L;
                            break;
                        case "heap": 
                            sampling = "v2";
                            p.Period = period / 2L;
                            break;
                        default: 
                            return (null, errUnrecognized);
                            break;
                    }
                }                header = growthHeaderRE.FindStringSubmatch(l);


                else if (header != null)
                {
                    p = ref new Profile(SampleType:[]*ValueType{{Type:"objects",Unit:"count"},{Type:"space",Unit:"bytes"},},PeriodType:&ValueType{Type:"heapgrowth",Unit:"count"},Period:1,);
                }                header = fragmentationHeaderRE.FindStringSubmatch(l);


                else if (header != null)
                {
                    p = ref new Profile(SampleType:[]*ValueType{{Type:"objects",Unit:"count"},{Type:"space",Unit:"bytes"},},PeriodType:&ValueType{Type:"allocations",Unit:"count"},Period:1,);
                }
                else
                {
                    return (null, errUnrecognized);
                }

            }

            if (LegacyHeapAllocated)
            {
                {
                    var st__prev1 = st;

                    foreach (var (_, __st) in p.SampleType)
                    {
                        st = __st;
                        st.Type = "alloc_" + st.Type;
                    }
            else

                    st = st__prev1;
                }

            }            {
                {
                    var st__prev1 = st;

                    foreach (var (_, __st) in p.SampleType)
                    {
                        st = __st;
                        st.Type = "inuse_" + st.Type;
                    }

                    st = st__prev1;
                }

            }
            var locs = make_map<ulong, ref Location>();
            while (true)
            {
                l, err = r.ReadString('\n');
                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return (null, err);
                    }
                    if (l == "")
                    {
                        break;
                    }
                }
                if (isSpaceOrComment(l))
                {
                    continue;
                }
                l = strings.TrimSpace(l);

                if (sectionTrigger(l) != unrecognizedSection)
                {
                    break;
                }
                var (value, blocksize, addrs, err) = parseHeapSample(l, p.Period, sampling);
                if (err != null)
                {
                    return (null, err);
                }
                slice<ref Location> sloc = default;
                foreach (var (_, addr) in addrs)
                { 
                    // Addresses from stack traces point to the next instruction after
                    // each call. Adjust by -1 to land somewhere on the actual call.
                    addr--;
                    var loc = locs[addr];
                    if (locs[addr] == null)
                    {
                        loc = ref new Location(Address:addr,);
                        p.Location = append(p.Location, loc);
                        locs[addr] = loc;
                    }
                    sloc = append(sloc, loc);
                }
                p.Sample = append(p.Sample, ref new Sample(Value:value,Location:sloc,NumLabel:map[string][]int64{"bytes":{blocksize}},));
            }


            err = parseAdditionalSections(l, r, p);

            if (err != null)
            {
                return (null, err);
            }
            return (p, null);
        }

        // parseHeapSample parses a single row from a heap profile into a new Sample.
        private static (slice<long>, long, slice<ulong>, error) parseHeapSample(@string line, long rate, @string sampling)
        {
            var sampleData = heapSampleRE.FindStringSubmatch(line);
            if (len(sampleData) != 6L)
            {
                return (value, blocksize, addrs, fmt.Errorf("unexpected number of sample values: got %d, want 6", len(sampleData)));
            } 

            // Use first two values by default; tcmalloc sampling generates the
            // same value for both, only the older heap-profile collect separate
            // stats for in-use and allocated objects.
            long valueIndex = 1L;
            if (LegacyHeapAllocated)
            {
                valueIndex = 3L;
            }
            long v1 = default;            long v2 = default;

            v1, err = strconv.ParseInt(sampleData[valueIndex], 10L, 64L);

            if (err != null)
            {
                return (value, blocksize, addrs, fmt.Errorf("malformed sample: %s: %v", line, err));
            }
            v2, err = strconv.ParseInt(sampleData[valueIndex + 1L], 10L, 64L);

            if (err != null)
            {
                return (value, blocksize, addrs, fmt.Errorf("malformed sample: %s: %v", line, err));
            }
            if (v1 == 0L)
            {
                if (v2 != 0L)
                {
                    return (value, blocksize, addrs, fmt.Errorf("allocation count was 0 but allocation bytes was %d", v2));
                }
            }
            else
            {
                blocksize = v2 / v1;
                if (sampling == "v2")
                {
                    v1, v2 = scaleHeapSample(v1, v2, rate);
                }
            }
            value = new slice<long>(new long[] { v1, v2 });
            addrs = parseHexAddresses(sampleData[5L]);

            return (value, blocksize, addrs, null);
        }

        // extractHexAddresses extracts hex numbers from a string and returns
        // them, together with their numeric value, in a slice.
        private static (slice<@string>, slice<ulong>) extractHexAddresses(@string s) => func((_, panic, __) =>
        {
            var hexStrings = hexNumberRE.FindAllString(s, -1L);
            slice<ulong> ids = default;
            foreach (var (_, s) in hexStrings)
            {
                {
                    var (id, err) = strconv.ParseUint(s, 0L, 64L);

                    if (err == null)
                    {
                        ids = append(ids, id);
                    }
                    else
                    { 
                        // Do not expect any parsing failures due to the regexp matching.
                        panic("failed to parse hex value:" + s);
                    }

                }
            }
            return (hexStrings, ids);
        });

        // parseHexAddresses parses hex numbers from a string and returns them
        // in a slice.
        private static slice<ulong> parseHexAddresses(@string s)
        {
            var (_, ids) = extractHexAddresses(s);
            return ids;
        }

        // scaleHeapSample adjusts the data from a heapz Sample to
        // account for its probability of appearing in the collected
        // data. heapz profiles are a sampling of the memory allocations
        // requests in a program. We estimate the unsampled value by dividing
        // each collected sample by its probability of appearing in the
        // profile. heapz v2 profiles rely on a poisson process to determine
        // which samples to collect, based on the desired average collection
        // rate R. The probability of a sample of size S to appear in that
        // profile is 1-exp(-S/R).
        private static (long, long) scaleHeapSample(long count, long size, long rate)
        {
            if (count == 0L || size == 0L)
            {
                return (0L, 0L);
            }
            if (rate <= 1L)
            { 
                // if rate==1 all samples were collected so no adjustment is needed.
                // if rate<1 treat as unknown and skip scaling.
                return (count, size);
            }
            var avgSize = float64(size) / float64(count);
            long scale = 1L / (1L - math.Exp(-avgSize / float64(rate)));

            return (int64(float64(count) * scale), int64(float64(size) * scale));
        }

        // parseContention parses a mutex or contention profile. There are 2 cases:
        // "--- contentionz " for legacy C++ profiles (and backwards compatibility)
        // "--- mutex:" or "--- contention:" for profiles generated by the Go runtime.
        // This code converts the text output from runtime into a *Profile. (In the future
        // the runtime might write a serialized Profile directly making this unnecessary.)
        private static (ref Profile, error) parseContention(slice<byte> b)
        {
            var r = bytes.NewBuffer(b);
            @string l = default;
            error err = default;
            while (true)
            { 
                // Skip past comments and empty lines seeking a real header.
                l, err = r.ReadString('\n');
                if (err != null)
                {
                    return (null, err);
                }
                if (!isSpaceOrComment(l))
                {
                    break;
                }
            }


            if (strings.HasPrefix(l, "--- contentionz "))
            {
                return parseCppContention(r);
            }
            else if (strings.HasPrefix(l, "--- mutex:"))
            {
                return parseCppContention(r);
            }
            else if (strings.HasPrefix(l, "--- contention:"))
            {
                return parseCppContention(r);
            }
            return (null, errUnrecognized);
        }

        // parseCppContention parses the output from synchronization_profiling.cc
        // for backward compatibility, and the compatible (non-debug) block profile
        // output from the Go runtime.
        private static (ref Profile, error) parseCppContention(ref bytes.Buffer r)
        {
            Profile p = ref new Profile(PeriodType:&ValueType{Type:"contentions",Unit:"count"},Period:1,SampleType:[]*ValueType{{Type:"contentions",Unit:"count"},{Type:"delay",Unit:"nanoseconds"},},);

            long cpuHz = default;
            @string l = default;
            error err = default; 
            // Parse text of the form "attribute = value" before the samples.
            const @string delimiter = "=";

            while (true)
            {
                l, err = r.ReadString('\n');
                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return (null, err);
                    }
                    if (l == "")
                    {
                        break;
                    }
                }
                if (isSpaceOrComment(l))
                {
                    continue;
                }
                l = strings.TrimSpace(l);

                if (l == "")
                {
                    continue;
                }
                if (strings.HasPrefix(l, "---"))
                {
                    break;
                }
                var attr = strings.SplitN(l, delimiter, 2L);
                if (len(attr) != 2L)
                {
                    break;
                }
                var key = strings.TrimSpace(attr[0L]);
                var val = strings.TrimSpace(attr[1L]);
                err = default;
                switch (key)
                {
                    case "cycles/second": 
                        cpuHz, err = strconv.ParseInt(val, 0L, 64L);

                        if (err != null)
                        {
                            return (null, errUnrecognized);
                        }
                        break;
                    case "sampling period": 
                        p.Period, err = strconv.ParseInt(val, 0L, 64L);

                        if (err != null)
                        {
                            return (null, errUnrecognized);
                        }
                        break;
                    case "ms since reset": 
                        var (ms, err) = strconv.ParseInt(val, 0L, 64L);
                        if (err != null)
                        {
                            return (null, errUnrecognized);
                        }
                        p.DurationNanos = ms * 1000L * 1000L;
                        break;
                    case "format": 
                        // CPP contentionz profiles don't have format.
                        return (null, errUnrecognized);
                        break;
                    case "resolution": 
                        // CPP contentionz profiles don't have resolution.
                        return (null, errUnrecognized);
                        break;
                    case "discarded samples": 
                        break;
                    default: 
                        return (null, errUnrecognized);
                        break;
                }
            }


            var locs = make_map<ulong, ref Location>();
            while (true)
            {
                if (!isSpaceOrComment(l))
                {
                    l = strings.TrimSpace(l);

                    if (strings.HasPrefix(l, "---"))
                    {
                        break;
                    }
                    var (value, addrs, err) = parseContentionSample(l, p.Period, cpuHz);
                    if (err != null)
                    {
                        return (null, err);
                    }
                    slice<ref Location> sloc = default;
                    foreach (var (_, addr) in addrs)
                    { 
                        // Addresses from stack traces point to the next instruction after
                        // each call. Adjust by -1 to land somewhere on the actual call.
                        addr--;
                        var loc = locs[addr];
                        if (locs[addr] == null)
                        {
                            loc = ref new Location(Address:addr,);
                            p.Location = append(p.Location, loc);
                            locs[addr] = loc;
                        }
                        sloc = append(sloc, loc);
                    }
                    p.Sample = append(p.Sample, ref new Sample(Value:value,Location:sloc,));
                }
                l, err = r.ReadString('\n');

                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return (null, err);
                    }
                    if (l == "")
                    {
                        break;
                    }
                }
            }


            err = error.As(parseAdditionalSections(l, r, p));

            if (err != null)
            {
                return (null, err);
            }
            return (p, null);
        }

        // parseContentionSample parses a single row from a contention profile
        // into a new Sample.
        private static (slice<long>, slice<ulong>, error) parseContentionSample(@string line, long period, long cpuHz)
        {
            var sampleData = contentionSampleRE.FindStringSubmatch(line);
            if (sampleData == null)
            {
                return (value, addrs, errUnrecognized);
            }
            var (v1, err) = strconv.ParseInt(sampleData[1L], 10L, 64L);
            if (err != null)
            {
                return (value, addrs, fmt.Errorf("malformed sample: %s: %v", line, err));
            }
            var (v2, err) = strconv.ParseInt(sampleData[2L], 10L, 64L);
            if (err != null)
            {
                return (value, addrs, fmt.Errorf("malformed sample: %s: %v", line, err));
            } 

            // Unsample values if period and cpuHz are available.
            // - Delays are scaled to cycles and then to nanoseconds.
            // - Contentions are scaled to cycles.
            if (period > 0L)
            {
                if (cpuHz > 0L)
                {
                    var cpuGHz = float64(cpuHz) / 1e9F;
                    v1 = int64(float64(v1) * float64(period) / cpuGHz);
                }
                v2 = v2 * period;
            }
            value = new slice<long>(new long[] { v2, v1 });
            addrs = parseHexAddresses(sampleData[3L]);

            return (value, addrs, null);
        }

        // parseThread parses a Threadz profile and returns a new Profile.
        private static (ref Profile, error) parseThread(slice<byte> b)
        {
            var r = bytes.NewBuffer(b);

            @string line = default;
            error err = default;
            while (true)
            { 
                // Skip past comments and empty lines seeking a real header.
                line, err = r.ReadString('\n');
                if (err != null)
                {
                    return (null, err);
                }
                if (!isSpaceOrComment(line))
                {
                    break;
                }
            }


            {
                var m = threadzStartRE.FindStringSubmatch(line);

                if (m != null)
                { 
                    // Advance over initial comments until first stack trace.
                    while (true)
                    {
                        line, err = r.ReadString('\n');
                        if (err != null)
                        {
                            if (err != io.EOF)
                            {
                                return (null, err);
                            }
                            if (line == "")
                            {
                                break;
                            }
                        }
                        if (sectionTrigger(line) != unrecognizedSection || line[0L] == '-')
                        {
                            break;
                        }
                    }

                }                {
                    var t__prev2 = t;

                    var t = threadStartRE.FindStringSubmatch(line);


                    else if (len(t) != 4L)
                    {
                        return (null, errUnrecognized);
                    }

                    t = t__prev2;

                }


            }

            Profile p = ref new Profile(SampleType:[]*ValueType{{Type:"thread",Unit:"count"}},PeriodType:&ValueType{Type:"thread",Unit:"count"},Period:1,);

            var locs = make_map<ulong, ref Location>(); 
            // Recognize each thread and populate profile samples.
            while (sectionTrigger(line) == unrecognizedSection)
            {
                if (strings.HasPrefix(line, "---- no stack trace for"))
                {
                    line = "";
                    break;
                }
                {
                    var t__prev1 = t;

                    t = threadStartRE.FindStringSubmatch(line);

                    if (len(t) != 4L)
                    {
                        return (null, errUnrecognized);
                    }

                    t = t__prev1;

                }

                slice<ulong> addrs = default;
                line, addrs, err = parseThreadSample(r);
                if (err != null)
                {
                    return (null, errUnrecognized);
                }
                if (len(addrs) == 0L)
                { 
                    // We got a --same as previous threads--. Bump counters.
                    if (len(p.Sample) > 0L)
                    {
                        var s = p.Sample[len(p.Sample) - 1L];
                        s.Value[0L]++;
                    }
                    continue;
                }
                slice<ref Location> sloc = default;
                foreach (var (_, addr) in addrs)
                { 
                    // Addresses from stack traces point to the next instruction after
                    // each call. Adjust by -1 to land somewhere on the actual call.
                    addr--;
                    var loc = locs[addr];
                    if (locs[addr] == null)
                    {
                        loc = ref new Location(Address:addr,);
                        p.Location = append(p.Location, loc);
                        locs[addr] = loc;
                    }
                    sloc = append(sloc, loc);
                }
                p.Sample = append(p.Sample, ref new Sample(Value:[]int64{1},Location:sloc,));
            }


            err = error.As(parseAdditionalSections(line, r, p));

            if (err != null)
            {
                return (null, err);
            }
            return (p, null);
        }

        // parseThreadSample parses a symbolized or unsymbolized stack trace.
        // Returns the first line after the traceback, the sample (or nil if
        // it hits a 'same-as-previous' marker) and an error.
        private static (@string, slice<ulong>, error) parseThreadSample(ref bytes.Buffer b)
        {
            @string l = default;
            var sameAsPrevious = false;
            while (true)
            {
                l, err = b.ReadString('\n');

                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return ("", null, err);
                    }
                    if (l == "")
                    {
                        break;
                    }
                }
                l = strings.TrimSpace(l);

                if (l == "")
                {
                    continue;
                }
                if (strings.HasPrefix(l, "---"))
                {
                    break;
                }
                if (strings.Contains(l, "same as previous thread"))
                {
                    sameAsPrevious = true;
                    continue;
                }
                addrs = append(addrs, parseHexAddresses(l));
            }


            if (sameAsPrevious)
            {
                return (l, null, null);
            }
            return (l, addrs, null);
        }

        // parseAdditionalSections parses any additional sections in the
        // profile, ignoring any unrecognized sections.
        private static error parseAdditionalSections(@string l, ref bytes.Buffer b, ref Profile p)
        {
            while (true)
            {
                if (sectionTrigger(l) == memoryMapSection)
                {
                    break;
                } 
                // Ignore any unrecognized sections.
                {
                    var (l, err) = b.ReadString('\n');

                    if (err != null)
                    {
                        if (err != io.EOF)
                        {
                            return error.As(err);
                        }
                        if (l == "")
                        {
                            break;
                        }
                    }

                }
            }

            return error.As(p.ParseMemoryMap(b));
        }

        // ParseMemoryMap parses a memory map in the format of
        // /proc/self/maps, and overrides the mappings in the current profile.
        // It renumbers the samples and locations in the profile correspondingly.
        private static error ParseMemoryMap(this ref Profile p, io.Reader rd)
        {
            var b = bufio.NewReader(rd);

            slice<@string> attrs = default;
            ref strings.Replacer r = default;
            const @string delimiter = "=";

            while (true)
            {
                var (l, err) = b.ReadString('\n');
                if (err != null)
                {
                    if (err != io.EOF)
                    {
                        return error.As(err);
                    }
                    if (l == "")
                    {
                        break;
                    }
                }
                l = strings.TrimSpace(l);

                if (l == "")
                {
                    continue;
                }
                if (r != null)
                {
                    l = r.Replace(l);
                }
                var (m, err) = parseMappingEntry(l);
                if (err != null)
                {
                    if (err == errUnrecognized)
                    { 
                        // Recognize assignments of the form: attr=value, and replace
                        // $attr with value on subsequent mappings.
                        {
                            var attr = strings.SplitN(l, delimiter, 2L);

                            if (len(attr) == 2L)
                            {
                                attrs = append(attrs, "$" + strings.TrimSpace(attr[0L]), strings.TrimSpace(attr[1L]));
                                r = strings.NewReplacer(attrs);
                            } 
                            // Ignore any unrecognized entries

                        } 
                        // Ignore any unrecognized entries
                        continue;
                    }
                    return error.As(err);
                }
                if (m == null || (m.File == "" && len(p.Mapping) != 0L))
                { 
                    // In some cases the first entry may include the address range
                    // but not the name of the file. It should be followed by
                    // another entry with the name.
                    continue;
                }
                if (len(p.Mapping) == 1L && p.Mapping[0L].File == "")
                { 
                    // Update the name if this is the entry following that empty one.
                    p.Mapping[0L].File = m.File;
                    continue;
                }
                p.Mapping = append(p.Mapping, m);
            }

            p.remapLocationIDs();
            p.remapFunctionIDs();
            p.remapMappingIDs();
            return error.As(null);
        }

        private static (ref Mapping, error) parseMappingEntry(@string l)
        {
            Mapping mapping = ref new Mapping();
            error err = default;
            {
                var me__prev1 = me;

                var me = procMapsRE.FindStringSubmatch(l);

                if (len(me) == 9L)
                {
                    if (!strings.Contains(me[3L], "x"))
                    { 
                        // Skip non-executable entries.
                        return (null, null);
                    }
                    mapping.Start, err = strconv.ParseUint(me[1L], 16L, 64L);

                    if (err != null)
                    {
                        return (null, errUnrecognized);
                    }
                    mapping.Limit, err = strconv.ParseUint(me[2L], 16L, 64L);

                    if (err != null)
                    {
                        return (null, errUnrecognized);
                    }
                    if (me[4L] != "")
                    {
                        mapping.Offset, err = strconv.ParseUint(me[4L], 16L, 64L);

                        if (err != null)
                        {
                            return (null, errUnrecognized);
                        }
                    }
                    mapping.File = me[8L];
                    return (mapping, null);
                }

                me = me__prev1;

            }

            {
                var me__prev1 = me;

                me = briefMapsRE.FindStringSubmatch(l);

                if (len(me) == 6L)
                {
                    mapping.Start, err = strconv.ParseUint(me[1L], 16L, 64L);

                    if (err != null)
                    {
                        return (null, errUnrecognized);
                    }
                    mapping.Limit, err = strconv.ParseUint(me[2L], 16L, 64L);

                    if (err != null)
                    {
                        return (null, errUnrecognized);
                    }
                    mapping.File = me[3L];
                    if (me[5L] != "")
                    {
                        mapping.Offset, err = strconv.ParseUint(me[5L], 16L, 64L);

                        if (err != null)
                        {
                            return (null, errUnrecognized);
                        }
                    }
                    return (mapping, null);
                }

                me = me__prev1;

            }

            return (null, errUnrecognized);
        }

        private partial struct sectionType // : long
        {
        }

        private static readonly sectionType unrecognizedSection = iota;
        private static readonly var memoryMapSection = 0;

        private static @string memoryMapTriggers = new slice<@string>(new @string[] { "--- Memory map: ---", "MAPPED_LIBRARIES:" });

        private static sectionType sectionTrigger(@string line)
        {
            foreach (var (_, trigger) in memoryMapTriggers)
            {
                if (strings.Contains(line, trigger))
                {
                    return memoryMapSection;
                }
            }
            return unrecognizedSection;
        }

        private static void addLegacyFrameInfo(this ref Profile p)
        {

            if (isProfileType(p, heapzSampleTypes) || isProfileType(p, heapzInUseSampleTypes) || isProfileType(p, heapzAllocSampleTypes)) 
                p.DropFrames = allocRxStr;
                p.KeepFrames = allocSkipRxStr;
            else if (isProfileType(p, contentionzSampleTypes)) 
                p.DropFrames = lockRxStr;
                p.KeepFrames = "";
            else 
                p.DropFrames = cpuProfilerRxStr;
                p.KeepFrames = "";
                    }

        private static @string heapzSampleTypes = new slice<@string>(new @string[] { "allocations", "size" }); // early Go pprof profiles
        private static @string heapzInUseSampleTypes = new slice<@string>(new @string[] { "inuse_objects", "inuse_space" });
        private static @string heapzAllocSampleTypes = new slice<@string>(new @string[] { "alloc_objects", "alloc_space" });
        private static @string contentionzSampleTypes = new slice<@string>(new @string[] { "contentions", "delay" });

        private static bool isProfileType(ref Profile p, slice<@string> t)
        {
            var st = p.SampleType;
            if (len(st) != len(t))
            {
                return false;
            }
            foreach (var (i) in st)
            {
                if (st[i].Type != t[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static var allocRxStr = strings.Join(new slice<@string>(new @string[] { `calloc`, `cfree`, `malloc`, `free`, `memalign`, `do_memalign`, `(__)?posix_memalign`, `pvalloc`, `valloc`, `realloc`, `tcmalloc::.*`, `tc_calloc`, `tc_cfree`, `tc_malloc`, `tc_free`, `tc_memalign`, `tc_posix_memalign`, `tc_pvalloc`, `tc_valloc`, `tc_realloc`, `tc_new`, `tc_delete`, `tc_newarray`, `tc_deletearray`, `tc_new_nothrow`, `tc_newarray_nothrow`, `malloc_zone_malloc`, `malloc_zone_calloc`, `malloc_zone_valloc`, `malloc_zone_realloc`, `malloc_zone_memalign`, `malloc_zone_free`, `runtime\..*`, `BaseArena::.*`, `(::)?do_malloc_no_errno`, `(::)?do_malloc_pages`, `(::)?do_malloc`, `DoSampledAllocation`, `MallocedMemBlock::MallocedMemBlock`, `_M_allocate`, `__builtin_(vec_)?delete`, `__builtin_(vec_)?new`, `__gnu_cxx::new_allocator::allocate`, `__libc_malloc`, `__malloc_alloc_template::allocate`, `allocate`, `cpp_alloc`, `operator new(\[\])?`, `simple_alloc::allocate` }), "|");

        private static var allocSkipRxStr = strings.Join(new slice<@string>(new @string[] { `runtime\.panic`, `runtime\.reflectcall`, `runtime\.call[0-9]*` }), "|");

        private static var cpuProfilerRxStr = strings.Join(new slice<@string>(new @string[] { `ProfileData::Add`, `ProfileData::prof_handler`, `CpuProfiler::prof_handler`, `__pthread_sighandler`, `__restore` }), "|");

        private static var lockRxStr = strings.Join(new slice<@string>(new @string[] { `RecordLockProfileData`, `(base::)?RecordLockProfileData.*`, `(base::)?SubmitMutexProfileData.*`, `(base::)?SubmitSpinLockProfileData.*`, `(Mutex::)?AwaitCommon.*`, `(Mutex::)?Unlock.*`, `(Mutex::)?UnlockSlow.*`, `(Mutex::)?ReaderUnlock.*`, `(MutexLock::)?~MutexLock.*`, `(SpinLock::)?Unlock.*`, `(SpinLock::)?SlowUnlock.*`, `(SpinLockHolder::)?~SpinLockHolder.*` }), "|");
    }
}}}}
