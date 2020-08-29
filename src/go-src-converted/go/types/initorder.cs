// Copyright 2014 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package types -- go2cs converted at 2020 August 29 08:47:39 UTC
// import "go/types" ==> using types = go.go.types_package
// Original source: C:\Go\src\go\types\initorder.go
using heap = go.container.heap_package;
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace go
{
    public static partial class types_package
    {
        // initOrder computes the Info.InitOrder for package variables.
        private static void initOrder(this ref Checker check)
        { 
            // An InitOrder may already have been computed if a package is
            // built from several calls to (*Checker).Files. Clear it.
            check.Info.InitOrder = check.Info.InitOrder[..0L]; 

            // Compute the object dependency graph and initialize
            // a priority queue with the list of graph nodes.
            var pq = nodeQueue(dependencyGraph(check.objMap));
            heap.Init(ref pq);

            const var debug = false;

            if (debug)
            {
                fmt.Printf("Computing initialization order for %s\n\n", check.pkg);
                fmt.Println("Object dependency graph:");
                {
                    var obj__prev1 = obj;

                    foreach (var (__obj, __d) in check.objMap)
                    {
                        obj = __obj;
                        d = __d; 
                        // only print objects that may appear in the dependency graph
                        {
                            var obj__prev2 = obj;

                            dependency (obj, _) = obj._<dependency>();

                            if (obj != null)
                            {
                                if (len(d.deps) > 0L)
                                {
                                    fmt.Printf("\t%s depends on\n", obj.Name());
                                    foreach (var (dep) in d.deps)
                                    {
                                        fmt.Printf("\t\t%s\n", dep.Name());
                                    }
                                else
                                }                                {
                                    fmt.Printf("\t%s has no dependencies\n", obj.Name());
                                }
                            }
                            obj = obj__prev2;

                        }
                    }
                    obj = obj__prev1;
                }

                fmt.Println();

                fmt.Println("Transposed object dependency graph (functions eliminated):");
                {
                    var n__prev1 = n;

                    foreach (var (_, __n) in pq)
                    {
                        n = __n;
                        fmt.Printf("\t%s depends on %d nodes\n", n.obj.Name(), n.ndeps);
                        {
                            var p__prev2 = p;

                            foreach (var (__p) in n.pred)
                            {
                                p = __p;
                                fmt.Printf("\t\t%s is dependent\n", p.obj.Name());
                            }
                            p = p__prev2;
                        }

                    }
                    n = n__prev1;
                }

                fmt.Println();

                fmt.Println("Processing nodes:");
            }
            var emitted = make_map<ref declInfo, bool>();
            while (len(pq) > 0L)
            { 
                // get the next node
                ref graphNode n = heap.Pop(ref pq)._<ref graphNode>();

                if (debug)
                {
                    fmt.Printf("\t%s (src pos %d) depends on %d nodes now\n", n.obj.Name(), n.obj.order(), n.ndeps);
                }
                if (n.ndeps > 0L)
                {
                    var cycle = findPath(check.objMap, n.obj, n.obj, make(objSet)); 
                    // If n.obj is not part of the cycle (e.g., n.obj->b->c->d->c),
                    // cycle will be nil. Don't report anything in that case since
                    // the cycle is reported when the algorithm gets to an object
                    // in the cycle.
                    // Furthermore, once an object in the cycle is encountered,
                    // the cycle will be broken (dependency count will be reduced
                    // below), and so the remaining nodes in the cycle don't trigger
                    // another error (unless they are part of multiple cycles).
                    if (cycle != null)
                    {
                        check.reportCycle(cycle);
                    }
                }
                {
                    var p__prev2 = p;

                    foreach (var (__p) in n.pred)
                    {
                        p = __p;
                        p.ndeps--;
                        heap.Fix(ref pq, p.index);
                    }
                    p = p__prev2;
                }

                ref Var (v, _) = n.obj._<ref Var>();
                var info = check.objMap[v];
                if (v == null || !info.hasInitializer())
                {
                    continue;
                }
                if (emitted[info])
                {
                    continue; // initializer already emitted, if any
                }
                emitted[info] = true;

                var infoLhs = info.lhs; // possibly nil (see declInfo.lhs field comment)
                if (infoLhs == null)
                {
                    infoLhs = new slice<ref Var>(new ref Var[] { v });
                }
                Initializer init = ref new Initializer(infoLhs,info.init);
                check.Info.InitOrder = append(check.Info.InitOrder, init);
            }

            if (debug)
            {
                fmt.Println();
                fmt.Println("Initialization order:");
                {
                    Initializer init__prev1 = init;

                    foreach (var (_, __init) in check.Info.InitOrder)
                    {
                        init = __init;
                        fmt.Printf("\t%s\n", init);
                    }
                    init = init__prev1;
                }

                fmt.Println();
            }
        }

        // findPath returns the (reversed) list of objects []Object{to, ... from}
        // such that there is a path of object dependencies from 'from' to 'to'.
        // If there is no such path, the result is nil.
        private static slice<Object> findPath(map<Object, ref declInfo> objMap, Object from, Object to, objSet visited)
        {
            if (visited[from])
            {
                return null; // node already seen
            }
            visited[from] = true;

            foreach (var (d) in objMap[from].deps)
            {
                if (d == to)
                {
                    return new slice<Object>(new Object[] { d });
                }
                {
                    var P = findPath(objMap, d, to, visited);

                    if (P != null)
                    {
                        return append(P, d);
                    }

                }
            }
            return null;
        }

        // reportCycle reports an error for the given cycle.
        private static void reportCycle(this ref Checker check, slice<Object> cycle)
        {
            var obj = cycle[0L];
            check.errorf(obj.Pos(), "initialization cycle for %s", obj.Name()); 
            // subtle loop: print cycle[i] for i = 0, n-1, n-2, ... 1 for len(cycle) = n
            for (var i = len(cycle) - 1L; i >= 0L; i--)
            {
                check.errorf(obj.Pos(), "\t%s refers to", obj.Name()); // secondary error, \t indented
                obj = cycle[i];
            } 
            // print cycle[0] again to close the cycle
 
            // print cycle[0] again to close the cycle
            check.errorf(obj.Pos(), "\t%s", obj.Name());
        }

        // ----------------------------------------------------------------------------
        // Object dependency graph

        // A dependency is an object that may be a dependency in an initialization
        // expression. Only constants, variables, and functions can be dependencies.
        // Constants are here because constant expression cycles are reported during
        // initialization order computation.
        private partial interface dependency : Object
        {
            void isDependency();
        }

        // A graphNode represents a node in the object dependency graph.
        // Each node p in n.pred represents an edge p->n, and each node
        // s in n.succ represents an edge n->s; with a->b indicating that
        // a depends on b.
        private partial struct graphNode
        {
            public dependency obj; // object represented by this node
            public nodeSet pred; // consumers and dependencies of this node (lazily initialized)
            public nodeSet succ; // consumers and dependencies of this node (lazily initialized)
            public long index; // node index in graph slice/priority queue
            public long ndeps; // number of outstanding dependencies before this object can be initialized
        }

        private partial struct nodeSet // : map<ref graphNode, bool>
        {
        }

        private static void add(this ref nodeSet s, ref graphNode p)
        {
            if (s == null.Value)
            {
                s.Value = make(nodeSet);
            }
            (s.Value)[p] = true;
        }

        // dependencyGraph computes the object dependency graph from the given objMap,
        // with any function nodes removed. The resulting graph contains only constants
        // and variables.
        private static slice<ref graphNode> dependencyGraph(map<Object, ref declInfo> objMap)
        { 
            // M is the dependency (Object) -> graphNode mapping
            var M = make_map<dependency, ref graphNode>();
            {
                var obj__prev1 = obj;

                foreach (var (__obj) in objMap)
                {
                    obj = __obj; 
                    // only consider nodes that may be an initialization dependency
                    {
                        var obj__prev1 = obj;

                        dependency (obj, _) = obj._<dependency>();

                        if (obj != null)
                        {
                            M[obj] = ref new graphNode(obj:obj);
                        }

                        obj = obj__prev1;

                    }
                } 

                // compute edges for graph M
                // (We need to include all nodes, even isolated ones, because they still need
                // to be scheduled for initialization in correct order relative to other nodes.)

                obj = obj__prev1;
            }

            {
                var obj__prev1 = obj;
                var n__prev1 = n;

                foreach (var (__obj, __n) in M)
                {
                    obj = __obj;
                    n = __n; 
                    // for each dependency obj -> d (= deps[i]), create graph edges n->s and s->n
                    {
                        var d__prev2 = d;

                        foreach (var (__d) in objMap[obj].deps)
                        {
                            d = __d; 
                            // only consider nodes that may be an initialization dependency
                            {
                                var d__prev1 = d;

                                dependency (d, _) = d._<dependency>();

                                if (d != null)
                                {
                                    var d = M[d];
                                    n.succ.add(d);
                                    d.pred.add(n);
                                }

                                d = d__prev1;

                            }
                        }

                        d = d__prev2;
                    }

                } 

                // remove function nodes and collect remaining graph nodes in G
                // (Mutually recursive functions may introduce cycles among themselves
                // which are permitted. Yet such cycles may incorrectly inflate the dependency
                // count for variables which in turn may not get scheduled for initialization
                // in correct order.)

                obj = obj__prev1;
                n = n__prev1;
            }

            slice<ref graphNode> G = default;
            {
                var obj__prev1 = obj;
                var n__prev1 = n;

                foreach (var (__obj, __n) in M)
                {
                    obj = __obj;
                    n = __n;
                    {
                        ref Func (_, ok) = obj._<ref Func>();

                        if (ok)
                        { 
                            // connect each predecessor p of n with each successor s
                            // and drop the function node (don't collect it in G)
                            foreach (var (p) in n.pred)
                            { 
                                // ignore self-cycles
                                if (p != n)
                                { 
                                    // Each successor s of n becomes a successor of p, and
                                    // each predecessor p of n becomes a predecessor of s.
                                    foreach (var (s) in n.succ)
                                    { 
                                        // ignore self-cycles
                                        if (s != n)
                                        {
                                            p.succ.add(s);
                                            s.pred.add(p);
                                            delete(s.pred, n); // remove edge to n
                                        }
                                    }
                                    delete(p.succ, n); // remove edge to n
                                }
                        else
                            }
                        }                        { 
                            // collect non-function nodes
                            G = append(G, n);
                        }

                    }
                } 

                // fill in index and ndeps fields

                obj = obj__prev1;
                n = n__prev1;
            }

            {
                var n__prev1 = n;

                foreach (var (__i, __n) in G)
                {
                    i = __i;
                    n = __n;
                    n.index = i;
                    n.ndeps = len(n.succ);
                }

                n = n__prev1;
            }

            return G;
        }

        // ----------------------------------------------------------------------------
        // Priority queue

        // nodeQueue implements the container/heap interface;
        // a nodeQueue may be used as a priority queue.
        private partial struct nodeQueue // : slice<ref graphNode>
        {
        }

        private static long Len(this nodeQueue a)
        {
            return len(a);
        }

        private static void Swap(this nodeQueue a, long i, long j)
        {
            var x = a[i];
            var y = a[j];
            a[i] = y;
            a[j] = x;
            x.index = j;
            y.index = i;
        }

        private static bool Less(this nodeQueue a, long i, long j)
        {
            var x = a[i];
            var y = a[j]; 
            // nodes are prioritized by number of incoming dependencies (1st key)
            // and source order (2nd key)
            return x.ndeps < y.ndeps || x.ndeps == y.ndeps && x.obj.order() < y.obj.order();
        }

        private static void Push(this ref nodeQueue _a, object x) => func(_a, (ref nodeQueue a, Defer _, Panic panic, Recover __) =>
        {
            panic("unreachable");
        });

        private static void Pop(this ref nodeQueue a)
        {
            var n = len(a.Value);
            var x = (a.Value)[n - 1L];
            x.index = -1L; // for safety
            a.Value = (a.Value)[..n - 1L];
            return x;
        }
    }
}}
