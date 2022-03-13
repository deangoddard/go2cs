// Copyright 2009 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package gc -- go2cs converted at 2022 March 13 06:25:31 UTC
// import "cmd/compile/internal/gc" ==> using gc = go.cmd.compile.@internal.gc_package
// Original source: C:\Program Files\Go\src\cmd\compile\internal\gc\export.go
namespace go.cmd.compile.@internal;

using @base = cmd.compile.@internal.@base_package;
using inline = cmd.compile.@internal.inline_package;
using ir = cmd.compile.@internal.ir_package;
using typecheck = cmd.compile.@internal.typecheck_package;
using types = cmd.compile.@internal.types_package;
using bio = cmd.@internal.bio_package;
using fmt = fmt_package;
using constant = go.constant_package;

public static partial class gc_package {

private static void exportf(ptr<bio.Writer> _addr_bout, @string format, params object[] args) {
    args = args.Clone();
    ref bio.Writer bout = ref _addr_bout.val;

    fmt.Fprintf(bout, format, args);
    if (@base.Debug.Export != 0) {
        fmt.Printf(format, args);
    }
}

private static void dumpexport(ptr<bio.Writer> _addr_bout) {
    ref bio.Writer bout = ref _addr_bout.val;

    ptr<exporter> p = addr(new exporter(marked:make(map[*types.Type]bool)));
    foreach (var (_, n) in typecheck.Target.Exports) { 
        // Must catch it here rather than Export(), because the type can be
        // not fully set (still TFORW) when Export() is called.
        if (n.Type() != null && n.Type().HasTParam()) {
            @base.Fatalf("Cannot (yet) export a generic type: %v", n);
        }
        p.markObject(n);
    }    exportf(_addr_bout, "\n$$B\n"); // indicate binary export format
    var off = bout.Offset();
    typecheck.WriteExports(bout.Writer);
    var size = bout.Offset() - off;
    exportf(_addr_bout, "\n$$\n");

    if (@base.Debug.Export != 0) {
        fmt.Printf("BenchmarkExportSize:%s 1 %d bytes\n", @base.Ctxt.Pkgpath, size);
    }
}

private static void dumpasmhdr() {
    var (b, err) = bio.Create(@base.Flag.AsmHdr);
    if (err != null) {
        @base.Fatalf("%v", err);
    }
    fmt.Fprintf(b, "// generated by compile -asmhdr from package %s\n\n", types.LocalPkg.Name);
    foreach (var (_, n) in typecheck.Target.Asms) {
        if (n.Sym().IsBlank()) {
            continue;
        }

        if (n.Op() == ir.OLITERAL) 
            var t = n.Val().Kind();
            if (t == constant.Float || t == constant.Complex) {
                break;
            }
            fmt.Fprintf(b, "#define const_%s %#v\n", n.Sym().Name, n.Val());
        else if (n.Op() == ir.OTYPE) 
            t = n.Type();
            if (!t.IsStruct() || t.StructType().Map != null || t.IsFuncArgStruct()) {
                break;
            }
            fmt.Fprintf(b, "#define %s__size %d\n", n.Sym().Name, int(t.Width));
            foreach (var (_, f) in t.Fields().Slice()) {
                if (!f.Sym.IsBlank()) {
                    fmt.Fprintf(b, "#define %s_%s %d\n", n.Sym().Name, f.Sym.Name, int(f.Offset));
                }
            }
            }    b.Close();
}

private partial struct exporter {
    public map<ptr<types.Type>, bool> marked; // types already seen by markType
}

// markObject visits a reachable object.
private static void markObject(this ptr<exporter> _addr_p, ir.Node n) {
    ref exporter p = ref _addr_p.val;

    if (n.Op() == ir.ONAME) {
        ptr<ir.Name> n = n._<ptr<ir.Name>>();
        if (n.Class == ir.PFUNC) {
            inline.Inline_Flood(n, typecheck.Export);
        }
    }
    p.markType(n.Type());
}

// markType recursively visits types reachable from t to identify
// functions whose inline bodies may be needed.
private static void markType(this ptr<exporter> _addr_p, ptr<types.Type> _addr_t) {
    ref exporter p = ref _addr_p.val;
    ref types.Type t = ref _addr_t.val;

    if (p.marked[t]) {
        return ;
    }
    p.marked[t] = true; 

    // If this is a named type, mark all of its associated
    // methods. Skip interface types because t.Methods contains
    // only their unexpanded method set (i.e., exclusive of
    // interface embeddings), and the switch statement below
    // handles their full method set.
    if (t.Sym() != null && t.Kind() != types.TINTER) {
        foreach (var (_, m) in t.Methods().Slice()) {
            if (types.IsExported(m.Sym.Name)) {
                p.markObject(ir.AsNode(m.Nname));
            }
        }
    }

    if (t.Kind() == types.TPTR || t.Kind() == types.TARRAY || t.Kind() == types.TSLICE) 
        p.markType(t.Elem());
    else if (t.Kind() == types.TCHAN) 
        if (t.ChanDir().CanRecv()) {
            p.markType(t.Elem());
        }
    else if (t.Kind() == types.TMAP) 
        p.markType(t.Key());
        p.markType(t.Elem());
    else if (t.Kind() == types.TSTRUCT) 
        {
            var f__prev1 = f;

            foreach (var (_, __f) in t.FieldSlice()) {
                f = __f;
                if (types.IsExported(f.Sym.Name) || f.Embedded != 0) {
                    p.markType(f.Type);
                }
            }

            f = f__prev1;
        }
    else if (t.Kind() == types.TFUNC) 
        {
            var f__prev1 = f;

            foreach (var (_, __f) in t.Results().FieldSlice()) {
                f = __f;
                p.markType(f.Type);
            }

            f = f__prev1;
        }
    else if (t.Kind() == types.TINTER) 
        {
            var f__prev1 = f;

            foreach (var (_, __f) in t.AllMethods().Slice()) {
                f = __f;
                if (types.IsExported(f.Sym.Name)) {
                    p.markType(f.Type);
                }
            }

            f = f__prev1;
        }
    }

} // end gc_package
