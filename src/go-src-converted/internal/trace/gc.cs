// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package trace -- go2cs converted at 2020 October 09 05:52:57 UTC
// import "internal/trace" ==> using trace = go.@internal.trace_package
// Original source: C:\Go\src\internal\trace\gc.go
using heap = go.container.heap_package;
using math = go.math_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using static go.builtin;

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        // MutatorUtil is a change in mutator utilization at a particular
        // time. Mutator utilization functions are represented as a
        // time-ordered []MutatorUtil.
        public partial struct MutatorUtil
        {
            public long Time; // Util is the mean mutator utilization starting at Time. This
// is in the range [0, 1].
            public double Util;
        }

        // UtilFlags controls the behavior of MutatorUtilization.
        public partial struct UtilFlags // : long
        {
        }

 
        // UtilSTW means utilization should account for STW events.
        public static readonly UtilFlags UtilSTW = (UtilFlags)1L << (int)(iota); 
        // UtilBackground means utilization should account for
        // background mark workers.
        public static readonly var UtilBackground = 0; 
        // UtilAssist means utilization should account for mark
        // assists.
        public static readonly var UtilAssist = 1; 
        // UtilSweep means utilization should account for sweeping.
        public static readonly var UtilSweep = 2; 

        // UtilPerProc means each P should be given a separate
        // utilization function. Otherwise, there is a single function
        // and each P is given a fraction of the utilization.
        public static readonly var UtilPerProc = 3;


        // MutatorUtilization returns a set of mutator utilization functions
        // for the given trace. Each function will always end with 0
        // utilization. The bounds of each function are implicit in the first
        // and last event; outside of these bounds each function is undefined.
        //
        // If the UtilPerProc flag is not given, this always returns a single
        // utilization function. Otherwise, it returns one function per P.
        public static slice<slice<MutatorUtil>> MutatorUtilization(slice<ptr<Event>> events, UtilFlags flags)
        {
            if (len(events) == 0L)
            {
                return null;
            }

            private partial struct perP
            {
                public long gc; // series the logical series number for this P. This
// is necessary because Ps may be removed and then
// re-added, and then the new P needs a new series.
                public long series;
            }
            perP ps = new slice<perP>(new perP[] {  });
            long stw = 0L;

            slice<MutatorUtil> @out = new slice<slice<MutatorUtil>>(new slice<MutatorUtil>[] {  });
            map assists = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<ulong, bool>{};
            map block = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<ulong, ptr<Event>>{};
            map bgMark = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<ulong, bool>{};

            foreach (var (_, ev) in events)
            {

                if (ev.Type == EvGomaxprocs)
                {
                    var gomaxprocs = int(ev.Args[0L]);
                    if (len(ps) > gomaxprocs)
                    {
                        if (flags & UtilPerProc != 0L)
                        { 
                            // End each P's series.
                            {
                                var p__prev2 = p;

                                foreach (var (_, __p) in ps[gomaxprocs..])
                                {
                                    p = __p;
                                    out[p.series] = addUtil(out[p.series], new MutatorUtil(ev.Ts,0));
                                }

                                p = p__prev2;
                            }
                        }

                        ps = ps[..gomaxprocs];

                    }

                    while (len(ps) < gomaxprocs)
                    { 
                        // Start new P's series.
                        long series = 0L;
                        if (flags & UtilPerProc != 0L || len(out) == 0L)
                        {
                            series = len(out);
                            out = append(out, new slice<MutatorUtil>(new MutatorUtil[] { {ev.Ts,1} }));
                        }

                        ps = append(ps, new perP(series:series));

                    }
                    goto __switch_break0;
                }
                if (ev.Type == EvGCSTWStart)
                {
                    if (flags & UtilSTW != 0L)
                    {
                        stw++;
                    }

                    goto __switch_break0;
                }
                if (ev.Type == EvGCSTWDone)
                {
                    if (flags & UtilSTW != 0L)
                    {
                        stw--;
                    }

                    goto __switch_break0;
                }
                if (ev.Type == EvGCMarkAssistStart)
                {
                    if (flags & UtilAssist != 0L)
                    {
                        ps[ev.P].gc++;
                        assists[ev.G] = true;
                    }

                    goto __switch_break0;
                }
                if (ev.Type == EvGCMarkAssistDone)
                {
                    if (flags & UtilAssist != 0L)
                    {
                        ps[ev.P].gc--;
                        delete(assists, ev.G);
                    }

                    goto __switch_break0;
                }
                if (ev.Type == EvGCSweepStart)
                {
                    if (flags & UtilSweep != 0L)
                    {
                        ps[ev.P].gc++;
                    }

                    goto __switch_break0;
                }
                if (ev.Type == EvGCSweepDone)
                {
                    if (flags & UtilSweep != 0L)
                    {
                        ps[ev.P].gc--;
                    }

                    goto __switch_break0;
                }
                if (ev.Type == EvGoStartLabel)
                {
                    if (flags & UtilBackground != 0L && strings.HasPrefix(ev.SArgs[0L], "GC ") && ev.SArgs[0L] != "GC (idle)")
                    { 
                        // Background mark worker.
                        //
                        // If we're in per-proc mode, we don't
                        // count dedicated workers because
                        // they kick all of the goroutines off
                        // that P, so don't directly
                        // contribute to goroutine latency.
                        if (!(flags & UtilPerProc != 0L && ev.SArgs[0L] == "GC (dedicated)"))
                        {
                            bgMark[ev.G] = true;
                            ps[ev.P].gc++;
                        }

                    }

                    fallthrough = true;
                }
                if (fallthrough || ev.Type == EvGoStart)
                {
                    if (assists[ev.G])
                    { 
                        // Unblocked during assist.
                        ps[ev.P].gc++;

                    }

                    block[ev.G] = ev.Link;
                    goto __switch_break0;
                }
                // default: 
                    if (ev != block[ev.G])
                    {
                        continue;
                    }

                    if (assists[ev.G])
                    { 
                        // Blocked during assist.
                        ps[ev.P].gc--;

                    }

                    if (bgMark[ev.G])
                    { 
                        // Background mark worker done.
                        ps[ev.P].gc--;
                        delete(bgMark, ev.G);

                    }

                    delete(block, ev.G);

                __switch_break0:;

                if (flags & UtilPerProc == 0L)
                { 
                    // Compute the current average utilization.
                    if (len(ps) == 0L)
                    {
                        continue;
                    }

                    long gcPs = 0L;
                    if (stw > 0L)
                    {
                        gcPs = len(ps);
                    }
                    else
                    {
                        {
                            var i__prev2 = i;

                            foreach (var (__i) in ps)
                            {
                                i = __i;
                                if (ps[i].gc > 0L)
                                {
                                    gcPs++;
                                }

                            }

                            i = i__prev2;
                        }
                    }
                else
                    MutatorUtil mu = new MutatorUtil(ev.Ts,1-float64(gcPs)/float64(len(ps))); 

                    // Record the utilization change. (Since
                    // len(ps) == len(out), we know len(out) > 0.)
                    out[0L] = addUtil(out[0L], mu);

                }                { 
                    // Check for per-P utilization changes.
                    {
                        var i__prev2 = i;

                        foreach (var (__i) in ps)
                        {
                            i = __i;
                            var p = _addr_ps[i];
                            float util = 1.0F;
                            if (stw > 0L || p.gc > 0L)
                            {
                                util = 0.0F;
                            }

                            out[p.series] = addUtil(out[p.series], new MutatorUtil(ev.Ts,util));

                        }

                        i = i__prev2;
                    }
                }

            } 

            // Add final 0 utilization event to any remaining series. This
            // is important to mark the end of the trace. The exact value
            // shouldn't matter since no window should extend beyond this,
            // but using 0 is symmetric with the start of the trace.
            mu = new MutatorUtil(events[len(events)-1].Ts,0);
            {
                var i__prev1 = i;

                foreach (var (__i) in ps)
                {
                    i = __i;
                    out[ps[i].series] = addUtil(out[ps[i].series], mu);
                }

                i = i__prev1;
            }

            return out;

        }

        private static slice<MutatorUtil> addUtil(slice<MutatorUtil> util, MutatorUtil mu)
        {
            if (len(util) > 0L)
            {
                if (mu.Util == util[len(util) - 1L].Util)
                { 
                    // No change.
                    return util;

                }

                if (mu.Time == util[len(util) - 1L].Time)
                { 
                    // Take the lowest utilization at a time stamp.
                    if (mu.Util < util[len(util) - 1L].Util)
                    {
                        util[len(util) - 1L] = mu;
                    }

                    return util;

                }

            }

            return append(util, mu);

        }

        // totalUtil is total utilization, measured in nanoseconds. This is a
        // separate type primarily to distinguish it from mean utilization,
        // which is also a float64.
        private partial struct totalUtil // : double
        {
        }

        private static totalUtil totalUtilOf(double meanUtil, long dur)
        {
            return totalUtil(meanUtil * float64(dur));
        }

        // mean returns the mean utilization over dur.
        private static double mean(this totalUtil u, time.Duration dur)
        {
            return float64(u) / float64(dur);
        }

        // An MMUCurve is the minimum mutator utilization curve across
        // multiple window sizes.
        public partial struct MMUCurve
        {
            public slice<mmuSeries> series;
        }

        private partial struct mmuSeries
        {
            public slice<MutatorUtil> util; // sums[j] is the cumulative sum of util[:j].
            public slice<totalUtil> sums; // bands summarizes util in non-overlapping bands of duration
// bandDur.
            public slice<mmuBand> bands; // bandDur is the duration of each band.
            public long bandDur;
        }

        private partial struct mmuBand
        {
            public double minUtil; // cumUtil is the cumulative total mutator utilization between
// time 0 and the left edge of this band.
            public totalUtil cumUtil; // integrator is the integrator for the left edge of this
// band.
            public integrator integrator;
        }

        // NewMMUCurve returns an MMU curve for the given mutator utilization
        // function.
        public static ptr<MMUCurve> NewMMUCurve(slice<slice<MutatorUtil>> utils)
        {
            var series = make_slice<mmuSeries>(len(utils));
            foreach (var (i, util) in utils)
            {
                series[i] = newMMUSeries(util);
            }
            return addr(new MMUCurve(series));

        }

        // bandsPerSeries is the number of bands to divide each series into.
        // This is only changed by tests.
        private static long bandsPerSeries = 1000L;

        private static mmuSeries newMMUSeries(slice<MutatorUtil> util)
        { 
            // Compute cumulative sum.
            var sums = make_slice<totalUtil>(len(util));
            MutatorUtil prev = default;
            totalUtil sum = default;
            foreach (var (j, u) in util)
            {
                sum += totalUtilOf(prev.Util, u.Time - prev.Time);
                sums[j] = sum;
                prev = u;
            } 

            // Divide the utilization curve up into equal size
            // non-overlapping "bands" and compute a summary for each of
            // these bands.
            //
            // Compute the duration of each band.
            var numBands = bandsPerSeries;
            if (numBands > len(util))
            { 
                // There's no point in having lots of bands if there
                // aren't many events.
                numBands = len(util);

            }

            var dur = util[len(util) - 1L].Time - util[0L].Time;
            var bandDur = (dur + int64(numBands) - 1L) / int64(numBands);
            if (bandDur < 1L)
            {
                bandDur = 1L;
            } 
            // Compute the bands. There are numBands+1 bands in order to
            // record the final cumulative sum.
            var bands = make_slice<mmuBand>(numBands + 1L);
            ref mmuSeries s = ref heap(new mmuSeries(util,sums,bands,bandDur), out ptr<mmuSeries> _addr_s);
            integrator leftSum = new integrator(&s,0);
            {
                var i__prev1 = i;

                foreach (var (__i) in bands)
                {
                    i = __i;
                    var (startTime, endTime) = s.bandTime(i);
                    var cumUtil = leftSum.advance(startTime);
                    var predIdx = leftSum.pos;
                    float minUtil = 1.0F;
                    {
                        var i__prev2 = i;

                        for (var i = predIdx; i < len(util) && util[i].Time < endTime; i++)
                        {
                            minUtil = math.Min(minUtil, util[i].Util);
                        }


                        i = i__prev2;
                    }
                    bands[i] = new mmuBand(minUtil,cumUtil,leftSum);

                }

                i = i__prev1;
            }

            return s;

        }

        private static (long, long) bandTime(this ptr<mmuSeries> _addr_s, long i)
        {
            long start = default;
            long end = default;
            ref mmuSeries s = ref _addr_s.val;

            start = int64(i) * s.bandDur + s.util[0L].Time;
            end = start + s.bandDur;
            return ;
        }

        private partial struct bandUtil
        {
            public long series; // Band index
            public long i; // Lower bound of mutator utilization for all windows
// with a left edge in this band.
            public double utilBound;
        }

        private partial struct bandUtilHeap // : slice<bandUtil>
        {
        }

        private static long Len(this bandUtilHeap h)
        {
            return len(h);
        }

        private static bool Less(this bandUtilHeap h, long i, long j)
        {
            return h[i].utilBound < h[j].utilBound;
        }

        private static void Swap(this bandUtilHeap h, long i, long j)
        {
            h[i] = h[j];
            h[j] = h[i];

        }

        private static void Push(this ptr<bandUtilHeap> _addr_h, object x)
        {
            ref bandUtilHeap h = ref _addr_h.val;

            h.val = append(h.val, x._<bandUtil>());
        }

        private static void Pop(this ptr<bandUtilHeap> _addr_h)
        {
            ref bandUtilHeap h = ref _addr_h.val;

            var x = (h.val)[len(h.val) - 1L];
            h.val = (h.val)[..len(h.val) - 1L];
            return x;
        }

        // UtilWindow is a specific window at Time.
        public partial struct UtilWindow
        {
            public long Time; // MutatorUtil is the mean mutator utilization in this window.
            public double MutatorUtil;
        }

        private partial struct utilHeap // : slice<UtilWindow>
        {
        }

        private static long Len(this utilHeap h)
        {
            return len(h);
        }

        private static bool Less(this utilHeap h, long i, long j)
        {
            if (h[i].MutatorUtil != h[j].MutatorUtil)
            {
                return h[i].MutatorUtil > h[j].MutatorUtil;
            }

            return h[i].Time > h[j].Time;

        }

        private static void Swap(this utilHeap h, long i, long j)
        {
            h[i] = h[j];
            h[j] = h[i];

        }

        private static void Push(this ptr<utilHeap> _addr_h, object x)
        {
            ref utilHeap h = ref _addr_h.val;

            h.val = append(h.val, x._<UtilWindow>());
        }

        private static void Pop(this ptr<utilHeap> _addr_h)
        {
            ref utilHeap h = ref _addr_h.val;

            var x = (h.val)[len(h.val) - 1L];
            h.val = (h.val)[..len(h.val) - 1L];
            return x;
        }

        // An accumulator takes a windowed mutator utilization function and
        // tracks various statistics for that function.
        private partial struct accumulator
        {
            public double mmu; // bound is the mutator utilization bound where adding any
// mutator utilization above this bound cannot affect the
// accumulated statistics.
            public double bound; // Worst N window tracking
            public long nWorst;
            public utilHeap wHeap; // Mutator utilization distribution tracking
            public ptr<mud> mud; // preciseMass is the distribution mass that must be precise
// before accumulation is stopped.
            public double preciseMass; // lastTime and lastMU are the previous point added to the
// windowed mutator utilization function.
            public long lastTime;
            public double lastMU;
        }

        // resetTime declares a discontinuity in the windowed mutator
        // utilization function by resetting the current time.
        private static void resetTime(this ptr<accumulator> _addr_acc)
        {
            ref accumulator acc = ref _addr_acc.val;
 
            // This only matters for distribution collection, since that's
            // the only thing that depends on the progression of the
            // windowed mutator utilization function.
            acc.lastTime = math.MaxInt64;

        }

        // addMU adds a point to the windowed mutator utilization function at
        // (time, mu). This must be called for monotonically increasing values
        // of time.
        //
        // It returns true if further calls to addMU would be pointless.
        private static Duration addMU(this ptr<accumulator> _addr_acc, long time, double mu, time window)
        private static double MMU(this ptr<MMUCurve> _addr_c, time.Duration window)
        {
            double mmu = default;
            ref MMUCurve c = ref _addr_c.val;

            ref accumulator acc = ref heap(new accumulator(mmu:1.0,bound:1.0), out ptr<accumulator> _addr_acc);
            c.mmu(window, _addr_acc);
            return acc.mmu;
        }

        // Examples returns n specific examples of the lowest mutator
        // utilization for the given window size. The returned windows will be
        // disjoint (otherwise there would be a huge number of
        // mostly-overlapping windows at the single lowest point). There are
        // no guarantees on which set of disjoint windows this returns.
        private static slice<UtilWindow> Examples(this ptr<MMUCurve> _addr_c, time.Duration window, long n)
        {
            slice<UtilWindow> worst = default;
            ref MMUCurve c = ref _addr_c.val;

            ref accumulator acc = ref heap(new accumulator(mmu:1.0,bound:1.0,nWorst:n), out ptr<accumulator> _addr_acc);
            c.mmu(window, _addr_acc);
            sort.Sort(sort.Reverse(acc.wHeap));
            return (slice<UtilWindow>)acc.wHeap;
        }

        // MUD returns mutator utilization distribution quantiles for the
        // given window size.
        //
        // The mutator utilization distribution is the distribution of mean
        // mutator utilization across all windows of the given window size in
        // the trace.
        //
        // The minimum mutator utilization is the minimum (0th percentile) of
        // this distribution. (However, if only the minimum is desired, it's
        // more efficient to use the MMU method.)
        private static slice<double> MUD(this ptr<MMUCurve> _addr_c, time.Duration window, slice<double> quantiles)
        {
            ref MMUCurve c = ref _addr_c.val;

            if (len(quantiles) == 0L)
            {>>MARKER:FUNCTION_addMU_BLOCK_PREFIX<<
                return new slice<double>(new double[] {  });
            } 

            // Each unrefined band contributes a known total mass to the
            // distribution (bandDur except at the end), but in an unknown
            // way. However, we know that all the mass it contributes must
            // be at or above its worst-case mean mutator utilization.
            //
            // Hence, we refine bands until the highest desired
            // distribution quantile is less than the next worst-case mean
            // mutator utilization. At this point, all further
            // contributions to the distribution must be beyond the
            // desired quantile and hence cannot affect it.
            //
            // First, find the highest desired distribution quantile.
            var maxQ = quantiles[0L];
            foreach (var (_, q) in quantiles)
            {
                if (q > maxQ)
                {
                    maxQ = q;
                }

            } 
            // The distribution's mass is in units of time (it's not
            // normalized because this would make it more annoying to
            // account for future contributions of unrefined bands). The
            // total final mass will be the duration of the trace itself
            // minus the window size. Using this, we can compute the mass
            // corresponding to quantile maxQ.
            long duration = default;
            foreach (var (_, s) in c.series)
            {
                var duration1 = s.util[len(s.util) - 1L].Time - s.util[0L].Time;
                if (duration1 >= int64(window))
                {
                    duration += duration1 - int64(window);
                }

            }
            var qMass = float64(duration) * maxQ; 

            // Accumulate the MUD until we have precise information for
            // everything to the left of qMass.
            ref accumulator acc = ref heap(new accumulator(mmu:1.0,bound:1.0,preciseMass:qMass,mud:new(mud)), out ptr<accumulator> _addr_acc);
            acc.mud.setTrackMass(qMass);
            c.mmu(window, _addr_acc); 

            // Evaluate the quantiles on the accumulated MUD.
            var @out = make_slice<double>(len(quantiles));
            foreach (var (i) in out)
            {
                var (mu, _) = acc.mud.invCumulativeSum(float64(duration) * quantiles[i]);
                if (math.IsNaN(mu))
                { 
                    // There are a few legitimate ways this can
                    // happen:
                    //
                    // 1. If the window is the full trace
                    // duration, then the windowed MU function is
                    // only defined at a single point, so the MU
                    // distribution is not well-defined.
                    //
                    // 2. If there are no events, then the MU
                    // distribution has no mass.
                    //
                    // Either way, all of the quantiles will have
                    // converged toward the MMU at this point.
                    mu = acc.mmu;

                }

                out[i] = mu;

            }
            return out;

        }

        private static void mmu(this ptr<MMUCurve> _addr_c, time.Duration window, ptr<accumulator> _addr_acc)
        {
            ref MMUCurve c = ref _addr_c.val;
            ref accumulator acc = ref _addr_acc.val;

            if (window <= 0L)
            {
                acc.mmu = 0L;
                return ;
            }

            ref bandUtilHeap bandU = ref heap(out ptr<bandUtilHeap> _addr_bandU);
            var windows = make_slice<time.Duration>(len(c.series));
            {
                var i__prev1 = i;

                foreach (var (__i, __s) in c.series)
                {
                    i = __i;
                    s = __s;
                    windows[i] = window;
                    {
                        var max = time.Duration(s.util[len(s.util) - 1L].Time - s.util[0L].Time);

                        if (window > max)
                        {
                            windows[i] = max;
                        }

                    }


                    var bandU1 = bandUtilHeap(s.mkBandUtil(i, windows[i]));
                    if (bandU == null)
                    {
                        bandU = bandU1;
                    }
                    else
                    {
                        bandU = append(bandU, bandU1);
                    }

                } 

                // Process bands from lowest utilization bound to highest.

                i = i__prev1;
            }

            heap.Init(_addr_bandU); 

            // Refine each band into a precise window and MMU until
            // refining the next lowest band can no longer affect the MMU
            // or windows.
            while (len(bandU) > 0L && bandU[0L].utilBound < acc.bound)
            {
                var i = bandU[0L].series;
                c.series[i].bandMMU(bandU[0L].i, windows[i], acc);
                heap.Pop(_addr_bandU);
            }


        }

        private static slice<bandUtil> mkBandUtil(this ptr<mmuSeries> _addr_c, long series, time.Duration window) => func((_, panic, __) =>
        {
            ref mmuSeries c = ref _addr_c.val;
 
            // For each band, compute the worst-possible total mutator
            // utilization for all windows that start in that band.

            // minBands is the minimum number of bands a window can span
            // and maxBands is the maximum number of bands a window can
            // span in any alignment.
            var minBands = int((int64(window) + c.bandDur - 1L) / c.bandDur);
            var maxBands = int((int64(window) + 2L * (c.bandDur - 1L)) / c.bandDur);
            if (window > 1L && maxBands < 2L)
            {
                panic("maxBands < 2");
            }

            var tailDur = int64(window) % c.bandDur;
            var nUtil = len(c.bands) - maxBands + 1L;
            if (nUtil < 0L)
            {
                nUtil = 0L;
            }

            var bandU = make_slice<bandUtil>(nUtil);
            foreach (var (i) in bandU)
            { 
                // To compute the worst-case MU, we assume the minimum
                // for any bands that are only partially overlapped by
                // some window and the mean for any bands that are
                // completely covered by all windows.
                totalUtil util = default; 

                // Find the lowest and second lowest of the partial
                // bands.
                var l = c.bands[i].minUtil;
                var r1 = c.bands[i + minBands - 1L].minUtil;
                var r2 = c.bands[i + maxBands - 1L].minUtil;
                var minBand = math.Min(l, math.Min(r1, r2)); 
                // Assume the worst window maximally overlaps the
                // worst minimum and then the rest overlaps the second
                // worst minimum.
                if (minBands == 1L)
                {
                    util += totalUtilOf(minBand, int64(window));
                }
                else
                {
                    util += totalUtilOf(minBand, c.bandDur);
                    float midBand = 0.0F;

                    if (minBand == l) 
                        midBand = math.Min(r1, r2);
                    else if (minBand == r1) 
                        midBand = math.Min(l, r2);
                    else if (minBand == r2) 
                        midBand = math.Min(l, r1);
                                        util += totalUtilOf(midBand, tailDur);

                } 

                // Add the total mean MU of bands that are completely
                // overlapped by all windows.
                if (minBands > 2L)
                {
                    util += c.bands[i + minBands - 1L].cumUtil - c.bands[i + 1L].cumUtil;
                }

                bandU[i] = new bandUtil(series,i,util.mean(window));

            }
            return bandU;

        });

        // bandMMU computes the precise minimum mutator utilization for
        // windows with a left edge in band bandIdx.
        private static void bandMMU(this ptr<mmuSeries> _addr_c, long bandIdx, time.Duration window, ptr<accumulator> _addr_acc)
        {
            ref mmuSeries c = ref _addr_c.val;
            ref accumulator acc = ref _addr_acc.val;

            var util = c.util; 

            // We think of the mutator utilization over time as the
            // box-filtered utilization function, which we call the
            // "windowed mutator utilization function". The resulting
            // function is continuous and piecewise linear (unless
            // window==0, which we handle elsewhere), where the boundaries
            // between segments occur when either edge of the window
            // encounters a change in the instantaneous mutator
            // utilization function. Hence, the minimum of this function
            // will always occur when one of the edges of the window
            // aligns with a utilization change, so these are the only
            // points we need to consider.
            //
            // We compute the mutator utilization function incrementally
            // by tracking the integral from t=0 to the left edge of the
            // window and to the right edge of the window.
            var left = c.bands[bandIdx].integrator;
            var right = left;
            var (time, endTime) = c.bandTime(bandIdx);
            {
                var utilEnd = util[len(util) - 1L].Time - int64(window);

                if (utilEnd < endTime)
                {
                    endTime = utilEnd;
                }

            }

            acc.resetTime();
            while (true)
            { 
                // Advance edges to time and time+window.
                var mu = (right.advance(time + int64(window)) - left.advance(time)).mean(window);
                if (acc.addMU(time, mu, window))
                {
                    break;
                }

                if (time == endTime)
                {
                    break;
                } 

                // The maximum slope of the windowed mutator
                // utilization function is 1/window, so we can always
                // advance the time by at least (mu - mmu) * window
                // without dropping below mmu.
                var minTime = time + int64((mu - acc.bound) * float64(window)); 

                // Advance the window to the next time where either
                // the left or right edge of the window encounters a
                // change in the utilization curve.
                {
                    var t1 = left.next(time);
                    var t2 = right.next(time + int64(window)) - int64(window);

                    if (t1 < t2)
                    {
                        time = t1;
                    }
                    else
                    {
                        time = t2;
                    }

                }

                if (time < minTime)
                {
                    time = minTime;
                }

                if (time >= endTime)
                { 
                    // For MMUs we could stop here, but for MUDs
                    // it's important that we span the entire
                    // band.
                    time = endTime;

                }

            }


        }

        // An integrator tracks a position in a utilization function and
        // integrates it.
        private partial struct integrator
        {
            public ptr<mmuSeries> u; // pos is the index in u.util of the current time's non-strict
// predecessor.
            public long pos;
        }

        // advance returns the integral of the utilization function from 0 to
        // time. advance must be called on monotonically increasing values of
        // times.
        private static totalUtil advance(this ptr<integrator> _addr_@in, long time)
        {
            ref integrator @in = ref _addr_@in.val;

            var util = @in.u.util;
            var pos = @in.pos; 
            // Advance pos until pos+1 is time's strict successor (making
            // pos time's non-strict predecessor).
            //
            // Very often, this will be nearby, so we optimize that case,
            // but it may be arbitrarily far away, so we handled that
            // efficiently, too.
            const long maxSeq = (long)8L;

            if (pos + maxSeq < len(util) && util[pos + maxSeq].Time > time)
            { 
                // Nearby. Use a linear scan.
                while (pos + 1L < len(util) && util[pos + 1L].Time <= time)
                {
                    pos++;
                }
            else


            }            { 
                // Far. Binary search for time's strict successor.
                var l = pos;
                var r = len(util);
                while (l < r)
                {
                    var h = int(uint(l + r) >> (int)(1L));
                    if (util[h].Time <= time)
                    {
                        l = h + 1L;
                    }
                    else
                    {
                        r = h;
                    }

                }

                pos = l - 1L; // Non-strict predecessor.
            }

            @in.pos = pos;
            totalUtil partial = default;
            if (time != util[pos].Time)
            {
                partial = totalUtilOf(util[pos].Util, time - util[pos].Time);
            }

            return @in.u.sums[pos] + partial;

        }

        // next returns the smallest time t' > time of a change in the
        // utilization function.
        private static long next(this ptr<integrator> _addr_@in, long time)
        {
            ref integrator @in = ref _addr_@in.val;

            foreach (var (_, u) in @in.u.util[@in.pos..])
            {
                if (u.Time > time)
                {
                    return u.Time;
                }

            }
            return 1L << (int)(63L) - 1L;

        }
    }
}}
