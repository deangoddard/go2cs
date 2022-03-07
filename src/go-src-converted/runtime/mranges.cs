// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Address range data structure.
//
// This file contains an implementation of a data structure which
// manages ordered address ranges.

// package runtime -- go2cs converted at 2022 March 06 22:10:08 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Program Files\Go\src\runtime\mranges.go
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go;

public static partial class runtime_package {

    // addrRange represents a region of address space.
    //
    // An addrRange must never span a gap in the address space.
private partial struct addrRange {
    public offAddr @base;
    public offAddr limit;
}

// makeAddrRange creates a new address range from two virtual addresses.
//
// Throws if the base and limit are not in the same memory segment.
private static addrRange makeAddrRange(System.UIntPtr @base, System.UIntPtr limit) {
    addrRange r = new addrRange(offAddr{base},offAddr{limit});
    if ((base - arenaBaseOffset >= base) != (limit - arenaBaseOffset >= limit)) {
        throw("addr range base and limit are not in the same memory segment");
    }
    return r;

}

// size returns the size of the range represented in bytes.
private static System.UIntPtr size(this addrRange a) {
    if (!a.@base.lessThan(a.limit)) {
        return 0;
    }
    return a.limit.diff(a.@base);

}

// contains returns whether or not the range contains a given address.
private static bool contains(this addrRange a, System.UIntPtr addr) {
    return a.@base.lessEqual(new offAddr(addr)) && (new offAddr(addr)).lessThan(a.limit);
}

// subtract takes the addrRange toPrune and cuts out any overlap with
// from, then returns the new range. subtract assumes that a and b
// either don't overlap at all, only overlap on one side, or are equal.
// If b is strictly contained in a, thus forcing a split, it will throw.
private static addrRange subtract(this addrRange a, addrRange b) {
    if (b.@base.lessEqual(a.@base) && a.limit.lessEqual(b.limit)) {
        return new addrRange();
    }
    else if (a.@base.lessThan(b.@base) && b.limit.lessThan(a.limit)) {
        throw("bad prune");
    }
    else if (b.limit.lessThan(a.limit) && a.@base.lessThan(b.limit)) {
        a.@base = b.limit;
    }
    else if (a.@base.lessThan(b.@base) && b.@base.lessThan(a.limit)) {
        a.limit = b.@base;
    }
    return a;

}

// removeGreaterEqual removes all addresses in a greater than or equal
// to addr and returns the new range.
private static addrRange removeGreaterEqual(this addrRange a, System.UIntPtr addr) {
    if ((new offAddr(addr)).lessEqual(a.@base)) {
        return new addrRange();
    }
    if (a.limit.lessEqual(new offAddr(addr))) {
        return a;
    }
    return makeAddrRange(a.@base.addr(), addr);

}

 
// minOffAddr is the minimum address in the offset space, and
// it corresponds to the virtual address arenaBaseOffset.
private static offAddr minOffAddr = new offAddr(arenaBaseOffset);private static offAddr maxOffAddr = new offAddr((((1<<heapAddrBits)-1)+arenaBaseOffset)&uintptrMask);

// offAddr represents an address in a contiguous view
// of the address space on systems where the address space is
// segmented. On other systems, it's just a normal address.
private partial struct offAddr {
    public System.UIntPtr a;
}

// add adds a uintptr offset to the offAddr.
private static offAddr add(this offAddr l, System.UIntPtr bytes) {
    return new offAddr(a:l.a+bytes);
}

// sub subtracts a uintptr offset from the offAddr.
private static offAddr sub(this offAddr l, System.UIntPtr bytes) {
    return new offAddr(a:l.a-bytes);
}

// diff returns the amount of bytes in between the
// two offAddrs.
private static System.UIntPtr diff(this offAddr l1, offAddr l2) {
    return l1.a - l2.a;
}

// lessThan returns true if l1 is less than l2 in the offset
// address space.
private static bool lessThan(this offAddr l1, offAddr l2) {
    return (l1.a - arenaBaseOffset) < (l2.a - arenaBaseOffset);
}

// lessEqual returns true if l1 is less than or equal to l2 in
// the offset address space.
private static bool lessEqual(this offAddr l1, offAddr l2) {
    return (l1.a - arenaBaseOffset) <= (l2.a - arenaBaseOffset);
}

// equal returns true if the two offAddr values are equal.
private static bool equal(this offAddr l1, offAddr l2) { 
    // No need to compare in the offset space, it
    // means the same thing.
    return l1 == l2;

}

// addr returns the virtual address for this offset address.
private static System.UIntPtr addr(this offAddr l) {
    return l.a;
}

// addrRanges is a data structure holding a collection of ranges of
// address space.
//
// The ranges are coalesced eagerly to reduce the
// number ranges it holds.
//
// The slice backing store for this field is persistentalloc'd
// and thus there is no way to free it.
//
// addrRanges is not thread-safe.
private partial struct addrRanges {
    public slice<addrRange> ranges; // totalBytes is the total amount of address space in bytes counted by
// this addrRanges.
    public System.UIntPtr totalBytes; // sysStat is the stat to track allocations by this type
    public ptr<sysMemStat> sysStat;
}

private static void init(this ptr<addrRanges> _addr_a, ptr<sysMemStat> _addr_sysStat) {
    ref addrRanges a = ref _addr_a.val;
    ref sysMemStat sysStat = ref _addr_sysStat.val;

    var ranges = (notInHeapSlice.val)(@unsafe.Pointer(_addr_a.ranges));
    ranges.len = 0;
    ranges.cap = 16;
    ranges.array = (notInHeap.val)(persistentalloc(@unsafe.Sizeof(new addrRange()) * uintptr(ranges.cap), sys.PtrSize, sysStat));
    a.sysStat = sysStat;
    a.totalBytes = 0;
}

// findSucc returns the first index in a such that addr is
// less than the base of the addrRange at that index.
private static nint findSucc(this ptr<addrRanges> _addr_a, System.UIntPtr addr) {
    ref addrRanges a = ref _addr_a.val;

    offAddr @base = new offAddr(addr); 

    // Narrow down the search space via a binary search
    // for large addrRanges until we have at most iterMax
    // candidates left.
    const nint iterMax = 8;

    nint bot = 0;
    var top = len(a.ranges);
    while (top - bot > iterMax) {
        var i = ((top - bot) / 2) + bot;
        if (a.ranges[i].contains(@base.addr())) { 
            // a.ranges[i] contains base, so
            // its successor is the next index.
            return i + 1;

        }
        if (@base.lessThan(a.ranges[i].@base)) { 
            // In this case i might actually be
            // the successor, but we can't be sure
            // until we check the ones before it.
            top = i;

        }
        else
 { 
            // In this case we know base is
            // greater than or equal to a.ranges[i].limit-1,
            // so i is definitely not the successor.
            // We already checked i, so pick the next
            // one.
            bot = i + 1;

        }
    } 
    // There are top-bot candidates left, so
    // iterate over them and find the first that
    // base is strictly less than.
    {
        var i__prev1 = i;

        for (i = bot; i < top; i++) {
            if (@base.lessThan(a.ranges[i].@base)) {
                return i;
            }
        }

        i = i__prev1;
    }
    return top;

}

// findAddrGreaterEqual returns the smallest address represented by a
// that is >= addr. Thus, if the address is represented by a,
// then it returns addr. The second return value indicates whether
// such an address exists for addr in a. That is, if addr is larger than
// any address known to a, the second return value will be false.
private static (System.UIntPtr, bool) findAddrGreaterEqual(this ptr<addrRanges> _addr_a, System.UIntPtr addr) {
    System.UIntPtr _p0 = default;
    bool _p0 = default;
    ref addrRanges a = ref _addr_a.val;

    var i = a.findSucc(addr);
    if (i == 0) {
        return (a.ranges[0].@base.addr(), true);
    }
    if (a.ranges[i - 1].contains(addr)) {
        return (addr, true);
    }
    if (i < len(a.ranges)) {
        return (a.ranges[i].@base.addr(), true);
    }
    return (0, false);

}

// contains returns true if a covers the address addr.
private static bool contains(this ptr<addrRanges> _addr_a, System.UIntPtr addr) {
    ref addrRanges a = ref _addr_a.val;

    var i = a.findSucc(addr);
    if (i == 0) {
        return false;
    }
    return a.ranges[i - 1].contains(addr);

}

// add inserts a new address range to a.
//
// r must not overlap with any address range in a and r.size() must be > 0.
private static void add(this ptr<addrRanges> _addr_a, addrRange r) {
    ref addrRanges a = ref _addr_a.val;
 
    // The copies in this function are potentially expensive, but this data
    // structure is meant to represent the Go heap. At worst, copying this
    // would take ~160µs assuming a conservative copying rate of 25 GiB/s (the
    // copy will almost never trigger a page fault) for a 1 TiB heap with 4 MiB
    // arenas which is completely discontiguous. ~160µs is still a lot, but in
    // practice most platforms have 64 MiB arenas (which cuts this by a factor
    // of 16) and Go heaps are usually mostly contiguous, so the chance that
    // an addrRanges even grows to that size is extremely low.

    // An empty range has no effect on the set of addresses represented
    // by a, but passing a zero-sized range is almost always a bug.
    if (r.size() == 0) {
        print("runtime: range = {", hex(r.@base.addr()), ", ", hex(r.limit.addr()), "}\n");
        throw("attempted to add zero-sized address range");
    }
    var i = a.findSucc(r.@base.addr());
    var coalescesDown = i > 0 && a.ranges[i - 1].limit.equal(r.@base);
    var coalescesUp = i < len(a.ranges) && r.limit.equal(a.ranges[i].@base);
    if (coalescesUp && coalescesDown) { 
        // We have neighbors and they both border us.
        // Merge a.ranges[i-1], r, and a.ranges[i] together into a.ranges[i-1].
        a.ranges[i - 1].limit = a.ranges[i].limit; 

        // Delete a.ranges[i].
        copy(a.ranges[(int)i..], a.ranges[(int)i + 1..]);
        a.ranges = a.ranges[..(int)len(a.ranges) - 1];

    }
    else if (coalescesDown) { 
        // We have a neighbor at a lower address only and it borders us.
        // Merge the new space into a.ranges[i-1].
        a.ranges[i - 1].limit = r.limit;

    }
    else if (coalescesUp) { 
        // We have a neighbor at a higher address only and it borders us.
        // Merge the new space into a.ranges[i].
        a.ranges[i].@base = r.@base;

    }
    else
 { 
        // We may or may not have neighbors which don't border us.
        // Add the new range.
        if (len(a.ranges) + 1 > cap(a.ranges)) { 
            // Grow the array. Note that this leaks the old array, but since
            // we're doubling we have at most 2x waste. For a 1 TiB heap and
            // 4 MiB arenas which are all discontiguous (both very conservative
            // assumptions), this would waste at most 4 MiB of memory.
            var oldRanges = a.ranges;
            var ranges = (notInHeapSlice.val)(@unsafe.Pointer(_addr_a.ranges));
            ranges.len = len(oldRanges) + 1;
            ranges.cap = cap(oldRanges) * 2;
            ranges.array = (notInHeap.val)(persistentalloc(@unsafe.Sizeof(new addrRange()) * uintptr(ranges.cap), sys.PtrSize, a.sysStat)); 

            // Copy in the old array, but make space for the new range.
            copy(a.ranges[..(int)i], oldRanges[..(int)i]);
            copy(a.ranges[(int)i + 1..], oldRanges[(int)i..]);

        }
        else
 {
            a.ranges = a.ranges[..(int)len(a.ranges) + 1];
            copy(a.ranges[(int)i + 1..], a.ranges[(int)i..]);
        }
        a.ranges[i] = r;

    }
    a.totalBytes += r.size();

}

// removeLast removes and returns the highest-addressed contiguous range
// of a, or the last nBytes of that range, whichever is smaller. If a is
// empty, it returns an empty range.
private static addrRange removeLast(this ptr<addrRanges> _addr_a, System.UIntPtr nBytes) {
    ref addrRanges a = ref _addr_a.val;

    if (len(a.ranges) == 0) {
        return new addrRange();
    }
    var r = a.ranges[len(a.ranges) - 1];
    var size = r.size();
    if (size > nBytes) {
        var newEnd = r.limit.sub(nBytes);
        a.ranges[len(a.ranges) - 1].limit = newEnd;
        a.totalBytes -= nBytes;
        return new addrRange(newEnd,r.limit);
    }
    a.ranges = a.ranges[..(int)len(a.ranges) - 1];
    a.totalBytes -= size;
    return r;

}

// removeGreaterEqual removes the ranges of a which are above addr, and additionally
// splits any range containing addr.
private static void removeGreaterEqual(this ptr<addrRanges> _addr_a, System.UIntPtr addr) {
    ref addrRanges a = ref _addr_a.val;

    var pivot = a.findSucc(addr);
    if (pivot == 0) { 
        // addr is before all ranges in a.
        a.totalBytes = 0;
        a.ranges = a.ranges[..(int)0];
        return ;

    }
    var removed = uintptr(0);
    {
        var r__prev1 = r;

        foreach (var (_, __r) in a.ranges[(int)pivot..]) {
            r = __r;
            removed += r.size();
        }
        r = r__prev1;
    }

    {
        var r__prev1 = r;

        var r = a.ranges[pivot - 1];

        if (r.contains(addr)) {
            removed += r.size();
            r = r.removeGreaterEqual(addr);
            if (r.size() == 0) {
                pivot--;
            }
            else
 {
                removed -= r.size();
                a.ranges[pivot - 1] = r;
            }

        }
        r = r__prev1;

    }

    a.ranges = a.ranges[..(int)pivot];
    a.totalBytes -= removed;

}

// cloneInto makes a deep clone of a's state into b, re-using
// b's ranges if able.
private static void cloneInto(this ptr<addrRanges> _addr_a, ptr<addrRanges> _addr_b) {
    ref addrRanges a = ref _addr_a.val;
    ref addrRanges b = ref _addr_b.val;

    if (len(a.ranges) > cap(b.ranges)) { 
        // Grow the array.
        var ranges = (notInHeapSlice.val)(@unsafe.Pointer(_addr_b.ranges));
        ranges.len = 0;
        ranges.cap = cap(a.ranges);
        ranges.array = (notInHeap.val)(persistentalloc(@unsafe.Sizeof(new addrRange()) * uintptr(ranges.cap), sys.PtrSize, b.sysStat));

    }
    b.ranges = b.ranges[..(int)len(a.ranges)];
    b.totalBytes = a.totalBytes;
    copy(b.ranges, a.ranges);

}

} // end runtime_package
