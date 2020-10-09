// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package ssa -- go2cs converted at 2020 October 09 05:39:42 UTC
// import "cmd/compile/internal/ssa" ==> using ssa = go.cmd.compile.@internal.ssa_package
// Original source: C:\Go\src\cmd\compile\internal\ssa\writebarrier.go
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        // A ZeroRegion records parts of an object which are known to be zero.
        // A ZeroRegion only applies to a single memory state.
        // Each bit in mask is set if the corresponding pointer-sized word of
        // the base object is known to be zero.
        // In other words, if mask & (1<<i) != 0, then [base+i*ptrSize, base+(i+1)*ptrSize)
        // is known to be zero.
        public partial struct ZeroRegion
        {
            public ptr<Value> @base;
            public ulong mask;
        }

        // needwb reports whether we need write barrier for store op v.
        // v must be Store/Move/Zero.
        // zeroes provides known zero information (keyed by ID of memory-type values).
        private static bool needwb(ptr<Value> _addr_v, map<ID, ZeroRegion> zeroes)
        {
            ref Value v = ref _addr_v.val;

            ptr<types.Type> (t, ok) = v.Aux._<ptr<types.Type>>();
            if (!ok)
            {
                v.Fatalf("store aux is not a type: %s", v.LongString());
            }

            if (!t.HasHeapPointer())
            {
                return false;
            }

            if (IsStackAddr(_addr_v.Args[0L]))
            {
                return false; // write on stack doesn't need write barrier
            }

            if (v.Op == OpMove && IsReadOnlyGlobalAddr(_addr_v.Args[1L]) && IsNewObject(_addr_v.Args[0L], _addr_v.MemoryArg()))
            { 
                // Copying data from readonly memory into a fresh object doesn't need a write barrier.
                return false;

            }

            if (v.Op == OpStore && IsGlobalAddr(_addr_v.Args[1L]))
            { 
                // Storing pointers to non-heap locations into zeroed memory doesn't need a write barrier.
                var ptr = v.Args[0L];
                long off = default;
                ptr<types.Type> size = v.Aux._<ptr<types.Type>>().Size();
                while (ptr.Op == OpOffPtr)
                {
                    off += ptr.AuxInt;
                    ptr = ptr.Args[0L];
                }

                var ptrSize = v.Block.Func.Config.PtrSize;
                if (off % ptrSize != 0L || size % ptrSize != 0L)
                {
                    v.Fatalf("unaligned pointer write");
                }

                if (off < 0L || off + size > 64L * ptrSize)
                { 
                    // write goes off end of tracked offsets
                    return true;

                }

                var z = zeroes[v.MemoryArg().ID];
                if (ptr != z.@base)
                {
                    return true;
                }

                {
                    var i = off;

                    while (i < off + size)
                    {
                        if (z.mask >> (int)(uint(i / ptrSize)) & 1L == 0L)
                        {
                            return true; // not known to be zero
                        i += ptrSize;
                        }

                    } 
                    // All written locations are known to be zero - write barrier not needed.

                } 
                // All written locations are known to be zero - write barrier not needed.
                return false;

            }

            return true;

        }

        // writebarrier pass inserts write barriers for store ops (Store, Move, Zero)
        // when necessary (the condition above). It rewrites store ops to branches
        // and runtime calls, like
        //
        // if writeBarrier.enabled {
        //   gcWriteBarrier(ptr, val)    // Not a regular Go call
        // } else {
        //   *ptr = val
        // }
        //
        // A sequence of WB stores for many pointer fields of a single type will
        // be emitted together, with a single branch.
        private static void writebarrier(ptr<Func> _addr_f) => func((defer, _, __) =>
        {
            ref Func f = ref _addr_f.val;

            if (!f.fe.UseWriteBarrier())
            {
                return ;
            }

            ptr<Value> sb;            ptr<Value> sp;            ptr<Value> wbaddr;            ptr<Value> const0;

            ptr<obj.LSym> typedmemmove;            ptr<obj.LSym> typedmemclr;            ptr<obj.LSym> gcWriteBarrier;

            slice<ptr<Value>> stores = default;            slice<ptr<Value>> after = default;

            ptr<sparseSet> sset;
            slice<int> storeNumber = default;

            var zeroes = f.computeZeroMap();
            foreach (var (_, b) in f.Blocks)
            { // range loop is safe since the blocks we added contain no stores to expand
                // first, identify all the stores that need to insert a write barrier.
                // mark them with WB ops temporarily. record presence of WB ops.
                long nWBops = 0L; // count of temporarily created WB ops remaining to be rewritten in the current block
                {
                    var v__prev2 = v;

                    foreach (var (_, __v) in b.Values)
                    {
                        v = __v;

                        if (v.Op == OpStore || v.Op == OpMove || v.Op == OpZero) 
                            if (needwb(_addr_v, zeroes))
                            {

                                if (v.Op == OpStore) 
                                    v.Op = OpStoreWB;
                                else if (v.Op == OpMove) 
                                    v.Op = OpMoveWB;
                                else if (v.Op == OpZero) 
                                    v.Op = OpZeroWB;
                                                                nWBops++;

                            }

                                            }

                    v = v__prev2;
                }

                if (nWBops == 0L)
                {
                    continue;
                }

                if (wbaddr == null)
                { 
                    // lazily initialize global values for write barrier test and calls
                    // find SB and SP values in entry block
                    var initpos = f.Entry.Pos;
                    {
                        var v__prev2 = v;

                        foreach (var (_, __v) in f.Entry.Values)
                        {
                            v = __v;
                            if (v.Op == OpSB)
                            {
                                sb = v;
                            }

                            if (v.Op == OpSP)
                            {
                                sp = v;
                            }

                            if (sb != null && sp != null)
                            {
                                break;
                            }

                        }

                        v = v__prev2;
                    }

                    if (sb == null)
                    {
                        sb = f.Entry.NewValue0(initpos, OpSB, f.Config.Types.Uintptr);
                    }

                    if (sp == null)
                    {
                        sp = f.Entry.NewValue0(initpos, OpSP, f.Config.Types.Uintptr);
                    }

                    var wbsym = f.fe.Syslook("writeBarrier");
                    wbaddr = f.Entry.NewValue1A(initpos, OpAddr, f.Config.Types.UInt32Ptr, wbsym, sb);
                    gcWriteBarrier = f.fe.Syslook("gcWriteBarrier");
                    typedmemmove = f.fe.Syslook("typedmemmove");
                    typedmemclr = f.fe.Syslook("typedmemclr");
                    const0 = f.ConstInt32(f.Config.Types.UInt32, 0L); 

                    // allocate auxiliary data structures for computing store order
                    sset = f.newSparseSet(f.NumValues());
                    defer(f.retSparseSet(sset));
                    storeNumber = make_slice<int>(f.NumValues());

                } 

                // order values in store order
                b.Values = storeOrder(b.Values, sset, storeNumber);

                var firstSplit = true;
again:
                ptr<Value> last;
                long start = default;                long end = default;

                var values = b.Values;
FindSeq:
                for (var i = len(values) - 1L; i >= 0L; i--)
                {
                    var w = values[i];

                    if (w.Op == OpStoreWB || w.Op == OpMoveWB || w.Op == OpZeroWB) 
                        start = i;
                        if (last == null)
                        {
                            last = w;
                            end = i + 1L;
                        }

                    else if (w.Op == OpVarDef || w.Op == OpVarLive || w.Op == OpVarKill) 
                        continue;
                    else 
                        if (last == null)
                        {
                            continue;
                        }

                        _breakFindSeq = true;
                        break;
                                    }
                stores = append(stores[..0L], b.Values[start..end]); // copy to avoid aliasing
                after = append(after[..0L], b.Values[end..]);
                b.Values = b.Values[..start]; 

                // find the memory before the WB stores
                var mem = stores[0L].MemoryArg();
                var pos = stores[0L].Pos;
                var bThen = f.NewBlock(BlockPlain);
                var bElse = f.NewBlock(BlockPlain);
                var bEnd = f.NewBlock(b.Kind);
                bThen.Pos = pos;
                bElse.Pos = pos;
                bEnd.Pos = b.Pos;
                b.Pos = pos; 

                // set up control flow for end block
                bEnd.CopyControls(b);
                bEnd.Likely = b.Likely;
                foreach (var (_, e) in b.Succs)
                {
                    bEnd.Succs = append(bEnd.Succs, e);
                    e.b.Preds[e.i].b = bEnd;
                } 

                // set up control flow for write barrier test
                // load word, test word, avoiding partial register write from load byte.
                var cfgtypes = _addr_f.Config.Types;
                var flag = b.NewValue2(pos, OpLoad, cfgtypes.UInt32, wbaddr, mem);
                flag = b.NewValue2(pos, OpNeq32, cfgtypes.Bool, flag, const0);
                b.Kind = BlockIf;
                b.SetControl(flag);
                b.Likely = BranchUnlikely;
                b.Succs = b.Succs[..0L];
                b.AddEdgeTo(bThen);
                b.AddEdgeTo(bElse); 
                // TODO: For OpStoreWB and the buffered write barrier,
                // we could move the write out of the write barrier,
                // which would lead to fewer branches. We could do
                // something similar to OpZeroWB, since the runtime
                // could provide just the barrier half and then we
                // could unconditionally do an OpZero (which could
                // also generate better zeroing code). OpMoveWB is
                // trickier and would require changing how
                // cgoCheckMemmove works.
                bThen.AddEdgeTo(bEnd);
                bElse.AddEdgeTo(bEnd); 

                // for each write barrier store, append write barrier version to bThen
                // and simple store version to bElse
                var memThen = mem;
                var memElse = mem; 

                // If the source of a MoveWB is volatile (will be clobbered by a
                // function call), we need to copy it to a temporary location, as
                // marshaling the args of typedmemmove might clobber the value we're
                // trying to move.
                // Look for volatile source, copy it to temporary before we emit any
                // call.
                // It is unlikely to have more than one of them. Just do a linear
                // search instead of using a map.
                private partial struct volatileCopy
                {
                    public ptr<Value> src; // address of original volatile value
                    public ptr<Value> tmp; // address of temporary we've copied the volatile value into
                }
                slice<volatileCopy> volatiles = default;
copyLoop:

                {
                    var w__prev2 = w;

                    foreach (var (_, __w) in stores)
                    {
                        w = __w;
                        if (w.Op == OpMoveWB)
                        {
                            var val = w.Args[1L];
                            if (isVolatile(_addr_val))
                            {
                                {
                                    var c__prev3 = c;

                                    foreach (var (_, __c) in volatiles)
                                    {
                                        c = __c;
                                        if (val == c.src)
                                        {
                                            _continuecopyLoop = true; // already copied
                                            break;
                                        }

                                    }

                                    c = c__prev3;
                                }

                                var t = val.Type.Elem();
                                var tmp = f.fe.Auto(w.Pos, t);
                                memThen = bThen.NewValue1A(w.Pos, OpVarDef, types.TypeMem, tmp, memThen);
                                var tmpaddr = bThen.NewValue2A(w.Pos, OpLocalAddr, t.PtrTo(), tmp, sp, memThen);
                                var siz = t.Size();
                                memThen = bThen.NewValue3I(w.Pos, OpMove, types.TypeMem, siz, tmpaddr, val, memThen);
                                memThen.Aux = t;
                                volatiles = append(volatiles, new volatileCopy(val,tmpaddr));

                            }

                        }

                    }

                    w = w__prev2;
                }
                {
                    var w__prev2 = w;

                    foreach (var (_, __w) in stores)
                    {
                        w = __w;
                        var ptr = w.Args[0L];
                        pos = w.Pos;

                        ptr<obj.LSym> fn;
                        ptr<obj.LSym> typ;
                        val = ;

                        if (w.Op == OpStoreWB) 
                            val = w.Args[1L];
                            nWBops--;
                        else if (w.Op == OpMoveWB) 
                            fn = addr(typedmemmove);
                            val = w.Args[1L];
                            typ = w.Aux._<ptr<types.Type>>().Symbol();
                            nWBops--;
                        else if (w.Op == OpZeroWB) 
                            fn = addr(typedmemclr);
                            typ = w.Aux._<ptr<types.Type>>().Symbol();
                            nWBops--;
                        else if (w.Op == OpVarDef || w.Op == OpVarLive || w.Op == OpVarKill)                         // then block: emit write barrier call

                        if (w.Op == OpStoreWB || w.Op == OpMoveWB || w.Op == OpZeroWB) 
                            if (w.Op == OpStoreWB)
                            {
                                memThen = bThen.NewValue3A(pos, OpWB, types.TypeMem, gcWriteBarrier, ptr, val, memThen);
                            }
                            else
                            {
                                var srcval = val;
                                if (w.Op == OpMoveWB && isVolatile(_addr_srcval))
                                {
                                    {
                                        var c__prev3 = c;

                                        foreach (var (_, __c) in volatiles)
                                        {
                                            c = __c;
                                            if (srcval == c.src)
                                            {
                                                srcval = c.tmp;
                                                break;
                                            }

                                        }

                                        c = c__prev3;
                                    }
                                }

                                memThen = wbcall(pos, _addr_bThen, fn, typ, _addr_ptr, _addr_srcval, _addr_memThen, sp, sb);

                            } 
                            // Note that we set up a writebarrier function call.
                            f.fe.SetWBPos(pos);
                        else if (w.Op == OpVarDef || w.Op == OpVarLive || w.Op == OpVarKill) 
                            memThen = bThen.NewValue1A(pos, w.Op, types.TypeMem, w.Aux, memThen);
                        // else block: normal store

                        if (w.Op == OpStoreWB) 
                            memElse = bElse.NewValue3A(pos, OpStore, types.TypeMem, w.Aux, ptr, val, memElse);
                        else if (w.Op == OpMoveWB) 
                            memElse = bElse.NewValue3I(pos, OpMove, types.TypeMem, w.AuxInt, ptr, val, memElse);
                            memElse.Aux = w.Aux;
                        else if (w.Op == OpZeroWB) 
                            memElse = bElse.NewValue2I(pos, OpZero, types.TypeMem, w.AuxInt, ptr, memElse);
                            memElse.Aux = w.Aux;
                        else if (w.Op == OpVarDef || w.Op == OpVarLive || w.Op == OpVarKill) 
                            memElse = bElse.NewValue1A(pos, w.Op, types.TypeMem, w.Aux, memElse);
                        
                    } 

                    // mark volatile temps dead

                    w = w__prev2;
                }

                {
                    var c__prev2 = c;

                    foreach (var (_, __c) in volatiles)
                    {
                        c = __c;
                        var tmpNode = c.tmp.Aux;
                        memThen = bThen.NewValue1A(memThen.Pos, OpVarKill, types.TypeMem, tmpNode, memThen);
                    } 

                    // merge memory
                    // Splice memory Phi into the last memory of the original sequence,
                    // which may be used in subsequent blocks. Other memories in the
                    // sequence must be dead after this block since there can be only
                    // one memory live.

                    c = c__prev2;
                }

                bEnd.Values = append(bEnd.Values, last);
                last.Block = bEnd;
                last.reset(OpPhi);
                last.Pos = last.Pos.WithNotStmt();
                last.Type = types.TypeMem;
                last.AddArg(memThen);
                last.AddArg(memElse);
                {
                    var w__prev2 = w;

                    foreach (var (_, __w) in stores)
                    {
                        w = __w;
                        if (w != last)
                        {
                            w.resetArgs();
                        }

                    }

                    w = w__prev2;
                }

                {
                    var w__prev2 = w;

                    foreach (var (_, __w) in stores)
                    {
                        w = __w;
                        if (w != last)
                        {
                            f.freeValue(w);
                        }

                    } 

                    // put values after the store sequence into the end block

                    w = w__prev2;
                }

                bEnd.Values = append(bEnd.Values, after);
                {
                    var w__prev2 = w;

                    foreach (var (_, __w) in after)
                    {
                        w = __w;
                        w.Block = bEnd;
                    } 

                    // Preemption is unsafe between loading the write
                    // barrier-enabled flag and performing the write
                    // because that would allow a GC phase transition,
                    // which would invalidate the flag. Remember the
                    // conditional block so liveness analysis can disable
                    // safe-points. This is somewhat subtle because we're
                    // splitting b bottom-up.

                    w = w__prev2;
                }

                if (firstSplit)
                { 
                    // Add b itself.
                    b.Func.WBLoads = append(b.Func.WBLoads, b);
                    firstSplit = false;

                }
                else
                { 
                    // We've already split b, so we just pushed a
                    // write barrier test into bEnd.
                    b.Func.WBLoads = append(b.Func.WBLoads, bEnd);

                } 

                // if we have more stores in this block, do this block again
                if (nWBops > 0L)
                {
                    goto again;
                }

            }

        });

        // computeZeroMap returns a map from an ID of a memory value to
        // a set of locations that are known to be zeroed at that memory value.
        private static map<ID, ZeroRegion> computeZeroMap(this ptr<Func> _addr_f)
        {
            ref Func f = ref _addr_f.val;

            var ptrSize = f.Config.PtrSize; 
            // Keep track of which parts of memory are known to be zero.
            // This helps with removing write barriers for various initialization patterns.
            // This analysis is conservative. We only keep track, for each memory state, of
            // which of the first 64 words of a single object are known to be zero.
            map zeroes = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<ID, ZeroRegion>{}; 
            // Find new objects.
            {
                var b__prev1 = b;

                foreach (var (_, __b) in f.Blocks)
                {
                    b = __b;
                    {
                        var v__prev2 = v;

                        foreach (var (_, __v) in b.Values)
                        {
                            v = __v;
                            if (v.Op != OpLoad)
                            {
                                continue;
                            }

                            var mem = v.MemoryArg();
                            if (IsNewObject(_addr_v, _addr_mem))
                            {
                                var nptr = v.Type.Elem().Size() / ptrSize;
                                if (nptr > 64L)
                                {
                                    nptr = 64L;
                                }

                                zeroes[mem.ID] = new ZeroRegion(base:v,mask:1<<uint(nptr)-1);

                            }

                        }

                        v = v__prev2;
                    }
                } 
                // Find stores to those new objects.

                b = b__prev1;
            }

            while (true)
            {
                var changed = false;
                {
                    var b__prev2 = b;

                    foreach (var (_, __b) in f.Blocks)
                    {
                        b = __b; 
                        // Note: iterating forwards helps convergence, as values are
                        // typically (but not always!) in store order.
                        {
                            var v__prev3 = v;

                            foreach (var (_, __v) in b.Values)
                            {
                                v = __v;
                                if (v.Op != OpStore)
                                {
                                    continue;
                                }

                                var (z, ok) = zeroes[v.MemoryArg().ID];
                                if (!ok)
                                {
                                    continue;
                                }

                                var ptr = v.Args[0L];
                                long off = default;
                                ptr<types.Type> size = v.Aux._<ptr<types.Type>>().Size();
                                while (ptr.Op == OpOffPtr)
                                {
                                    off += ptr.AuxInt;
                                    ptr = ptr.Args[0L];
                                }

                                if (ptr != z.@base)
                                { 
                                    // Different base object - we don't know anything.
                                    // We could even be writing to the base object we know
                                    // about, but through an aliased but offset pointer.
                                    // So we have to throw all the zero information we have away.
                                    continue;

                                } 
                                // Round to cover any partially written pointer slots.
                                // Pointer writes should never be unaligned like this, but non-pointer
                                // writes to pointer-containing types will do this.
                                {
                                    var d__prev1 = d;

                                    var d = off % ptrSize;

                                    if (d != 0L)
                                    {
                                        off -= d;
                                        size += d;
                                    }

                                    d = d__prev1;

                                }

                                {
                                    var d__prev1 = d;

                                    d = size % ptrSize;

                                    if (d != 0L)
                                    {
                                        size += ptrSize - d;
                                    } 
                                    // Clip to the 64 words that we track.

                                    d = d__prev1;

                                } 
                                // Clip to the 64 words that we track.
                                var min = off;
                                var max = off + size;
                                if (min < 0L)
                                {
                                    min = 0L;
                                }

                                if (max > 64L * ptrSize)
                                {
                                    max = 64L * ptrSize;
                                } 
                                // Clear bits for parts that we are writing (and hence
                                // will no longer necessarily be zero).
                                {
                                    var i = min;

                                    while (i < max)
                                    {
                                        var bit = i / ptrSize;
                                        z.mask &= 1L << (int)(uint(bit));
                                        i += ptrSize;
                                    }

                                }
                                if (z.mask == 0L)
                                { 
                                    // No more known zeros - don't bother keeping.
                                    continue;

                                } 
                                // Save updated known zero contents for new store.
                                if (zeroes[v.ID] != z)
                                {
                                    zeroes[v.ID] = z;
                                    changed = true;
                                }

                            }

                            v = v__prev3;
                        }
                    }

                    b = b__prev2;
                }

                if (!changed)
                {
                    break;
                }

            }

            if (f.pass.debug > 0L)
            {
                fmt.Printf("func %s\n", f.Name);
                {
                    var mem__prev1 = mem;
                    var z__prev1 = z;

                    foreach (var (__mem, __z) in zeroes)
                    {
                        mem = __mem;
                        z = __z;
                        fmt.Printf("  memory=v%d ptr=%v zeromask=%b\n", mem, z.@base, z.mask);
                    }

                    mem = mem__prev1;
                    z = z__prev1;
                }
            }

            return zeroes;

        }

        // wbcall emits write barrier runtime call in b, returns memory.
        private static ptr<Value> wbcall(src.XPos pos, ptr<Block> _addr_b, ptr<obj.LSym> _addr_fn, ptr<obj.LSym> _addr_typ, ptr<Value> _addr_ptr, ptr<Value> _addr_val, ptr<Value> _addr_mem, ptr<Value> _addr_sp, ptr<Value> _addr_sb)
        {
            ref Block b = ref _addr_b.val;
            ref obj.LSym fn = ref _addr_fn.val;
            ref obj.LSym typ = ref _addr_typ.val;
            ref Value ptr = ref _addr_ptr.val;
            ref Value val = ref _addr_val.val;
            ref Value mem = ref _addr_mem.val;
            ref Value sp = ref _addr_sp.val;
            ref Value sb = ref _addr_sb.val;

            var config = b.Func.Config; 

            // put arguments on stack
            var off = config.ctxt.FixedFrameSize();

            if (typ != null)
            { // for typedmemmove
                var taddr = b.NewValue1A(pos, OpAddr, b.Func.Config.Types.Uintptr, typ, sb);
                off = round(off, taddr.Type.Alignment());
                var arg = b.NewValue1I(pos, OpOffPtr, taddr.Type.PtrTo(), off, sp);
                mem = b.NewValue3A(pos, OpStore, types.TypeMem, ptr.Type, arg, taddr, mem);
                off += taddr.Type.Size();

            }

            off = round(off, ptr.Type.Alignment());
            arg = b.NewValue1I(pos, OpOffPtr, ptr.Type.PtrTo(), off, sp);
            mem = b.NewValue3A(pos, OpStore, types.TypeMem, ptr.Type, arg, ptr, mem);
            off += ptr.Type.Size();

            if (val != null)
            {
                off = round(off, val.Type.Alignment());
                arg = b.NewValue1I(pos, OpOffPtr, val.Type.PtrTo(), off, sp);
                mem = b.NewValue3A(pos, OpStore, types.TypeMem, val.Type, arg, val, mem);
                off += val.Type.Size();
            }

            off = round(off, config.PtrSize); 

            // issue call
            mem = b.NewValue1A(pos, OpStaticCall, types.TypeMem, fn, mem);
            mem.AuxInt = off - config.ctxt.FixedFrameSize();
            return _addr_mem!;

        }

        // round to a multiple of r, r is a power of 2
        private static long round(long o, long r)
        {
            return (o + r - 1L) & ~(r - 1L);
        }

        // IsStackAddr reports whether v is known to be an address of a stack slot.
        public static bool IsStackAddr(ptr<Value> _addr_v)
        {
            ref Value v = ref _addr_v.val;

            while (v.Op == OpOffPtr || v.Op == OpAddPtr || v.Op == OpPtrIndex || v.Op == OpCopy)
            {
                v = v.Args[0L];
            }


            if (v.Op == OpSP || v.Op == OpLocalAddr) 
                return true;
                        return false;

        }

        // IsGlobalAddr reports whether v is known to be an address of a global (or nil).
        public static bool IsGlobalAddr(ptr<Value> _addr_v)
        {
            ref Value v = ref _addr_v.val;

            if (v.Op == OpAddr && v.Args[0L].Op == OpSB)
            {
                return true; // address of a global
            }

            if (v.Op == OpConstNil)
            {
                return true;
            }

            if (v.Op == OpLoad && IsReadOnlyGlobalAddr(_addr_v.Args[0L]))
            {
                return true; // loading from a read-only global - the resulting address can't be a heap address.
            }

            return false;

        }

        // IsReadOnlyGlobalAddr reports whether v is known to be an address of a read-only global.
        public static bool IsReadOnlyGlobalAddr(ptr<Value> _addr_v)
        {
            ref Value v = ref _addr_v.val;

            if (v.Op == OpConstNil)
            { 
                // Nil pointers are read only. See issue 33438.
                return true;

            }

            if (v.Op == OpAddr && v.Aux._<ptr<obj.LSym>>().Type == objabi.SRODATA)
            {
                return true;
            }

            return false;

        }

        // IsNewObject reports whether v is a pointer to a freshly allocated & zeroed object at memory state mem.
        public static bool IsNewObject(ptr<Value> _addr_v, ptr<Value> _addr_mem)
        {
            ref Value v = ref _addr_v.val;
            ref Value mem = ref _addr_mem.val;

            if (v.Op != OpLoad)
            {
                return false;
            }

            if (v.MemoryArg() != mem)
            {
                return false;
            }

            if (mem.Op != OpStaticCall)
            {
                return false;
            }

            if (!isSameSym(mem.Aux, "runtime.newobject"))
            {
                return false;
            }

            if (v.Args[0L].Op != OpOffPtr)
            {
                return false;
            }

            if (v.Args[0L].Args[0L].Op != OpSP)
            {
                return false;
            }

            var c = v.Block.Func.Config;
            if (v.Args[0L].AuxInt != c.ctxt.FixedFrameSize() + c.RegSize)
            { // offset of return value
                return false;

            }

            return true;

        }

        // IsSanitizerSafeAddr reports whether v is known to be an address
        // that doesn't need instrumentation.
        public static bool IsSanitizerSafeAddr(ptr<Value> _addr_v)
        {
            ref Value v = ref _addr_v.val;

            while (v.Op == OpOffPtr || v.Op == OpAddPtr || v.Op == OpPtrIndex || v.Op == OpCopy)
            {
                v = v.Args[0L];
            }


            if (v.Op == OpSP || v.Op == OpLocalAddr) 
                // Stack addresses are always safe.
                return true;
            else if (v.Op == OpITab || v.Op == OpStringPtr || v.Op == OpGetClosurePtr) 
                // Itabs, string data, and closure fields are
                // read-only once initialized.
                return true;
            else if (v.Op == OpAddr) 
                return v.Aux._<ptr<obj.LSym>>().Type == objabi.SRODATA;
                        return false;

        }

        // isVolatile reports whether v is a pointer to argument region on stack which
        // will be clobbered by a function call.
        private static bool isVolatile(ptr<Value> _addr_v)
        {
            ref Value v = ref _addr_v.val;

            while (v.Op == OpOffPtr || v.Op == OpAddPtr || v.Op == OpPtrIndex || v.Op == OpCopy)
            {
                v = v.Args[0L];
            }

            return v.Op == OpSP;

        }
    }
}}}}
