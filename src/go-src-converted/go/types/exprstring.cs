// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// This file implements printing of expressions.

// package types -- go2cs converted at 2022 March 06 22:41:57 UTC
// import "go/types" ==> using types = go.go.types_package
// Original source: C:\Program Files\Go\src\go\types\exprstring.go
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using typeparams = go.go.@internal.typeparams_package;

namespace go.go;

public static partial class types_package {

    // ExprString returns the (possibly shortened) string representation for x.
    // Shortened representations are suitable for user interfaces but may not
    // necessarily follow Go syntax.
public static @string ExprString(ast.Expr x) {
    ref bytes.Buffer buf = ref heap(out ptr<bytes.Buffer> _addr_buf);
    WriteExpr(_addr_buf, x);
    return buf.String();
}

// WriteExpr writes the (possibly shortened) string representation for x to buf.
// Shortened representations are suitable for user interfaces but may not
// necessarily follow Go syntax.
public static void WriteExpr(ptr<bytes.Buffer> _addr_buf, ast.Expr x) {
    ref bytes.Buffer buf = ref _addr_buf.val;
 
    // The AST preserves source-level parentheses so there is
    // no need to introduce them here to correct for different
    // operator precedences. (This assumes that the AST was
    // generated by a Go parser.)

    switch (x.type()) {
        case ptr<ast.Ident> x:
            buf.WriteString(x.Name);
            break;
        case ptr<ast.Ellipsis> x:
            buf.WriteString("...");
            if (x.Elt != null) {
                WriteExpr(_addr_buf, x.Elt);
            }
            break;
        case ptr<ast.BasicLit> x:
            buf.WriteString(x.Value);
            break;
        case ptr<ast.FuncLit> x:
            buf.WriteByte('(');
            WriteExpr(_addr_buf, x.Type);
            buf.WriteString(" literal)"); // shortened
            break;
        case ptr<ast.CompositeLit> x:
            buf.WriteByte('(');
            WriteExpr(_addr_buf, x.Type);
            buf.WriteString(" literal)"); // shortened
            break;
        case ptr<ast.ParenExpr> x:
            buf.WriteByte('(');
            WriteExpr(_addr_buf, x.X);
            buf.WriteByte(')');
            break;
        case ptr<ast.SelectorExpr> x:
            WriteExpr(_addr_buf, x.X);
            buf.WriteByte('.');
            buf.WriteString(x.Sel.Name);
            break;
        case ptr<ast.IndexExpr> x:
            WriteExpr(_addr_buf, x.X);
            buf.WriteByte('[');
            var exprs = typeparams.UnpackExpr(x.Index);
            foreach (var (i, e) in exprs) {
                if (i > 0) {
                    buf.WriteString(", ");
                }
                WriteExpr(_addr_buf, e);
            }
            buf.WriteByte(']');
            break;
        case ptr<ast.SliceExpr> x:
            WriteExpr(_addr_buf, x.X);
            buf.WriteByte('[');
            if (x.Low != null) {
                WriteExpr(_addr_buf, x.Low);
            }
            buf.WriteByte(':');
            if (x.High != null) {
                WriteExpr(_addr_buf, x.High);
            }
            if (x.Slice3) {
                buf.WriteByte(':');
                if (x.Max != null) {
                    WriteExpr(_addr_buf, x.Max);
                }
            }
            buf.WriteByte(']');
            break;
        case ptr<ast.TypeAssertExpr> x:
            WriteExpr(_addr_buf, x.X);
            buf.WriteString(".(");
            WriteExpr(_addr_buf, x.Type);
            buf.WriteByte(')');
            break;
        case ptr<ast.CallExpr> x:
            WriteExpr(_addr_buf, x.Fun);
            buf.WriteByte('(');
            writeExprList(_addr_buf, x.Args);
            if (x.Ellipsis.IsValid()) {
                buf.WriteString("...");
            }
            buf.WriteByte(')');
            break;
        case ptr<ast.StarExpr> x:
            buf.WriteByte('*');
            WriteExpr(_addr_buf, x.X);
            break;
        case ptr<ast.UnaryExpr> x:
            buf.WriteString(x.Op.String());
            WriteExpr(_addr_buf, x.X);
            break;
        case ptr<ast.BinaryExpr> x:
            WriteExpr(_addr_buf, x.X);
            buf.WriteByte(' ');
            buf.WriteString(x.Op.String());
            buf.WriteByte(' ');
            WriteExpr(_addr_buf, x.Y);
            break;
        case ptr<ast.ArrayType> x:
            buf.WriteByte('[');
            if (x.Len != null) {
                WriteExpr(_addr_buf, x.Len);
            }
            buf.WriteByte(']');
            WriteExpr(_addr_buf, x.Elt);
            break;
        case ptr<ast.StructType> x:
            buf.WriteString("struct{");
            writeFieldList(_addr_buf, x.Fields.List, "; ", false);
            buf.WriteByte('}');
            break;
        case ptr<ast.FuncType> x:
            buf.WriteString("func");
            writeSigExpr(_addr_buf, _addr_x);
            break;
        case ptr<ast.InterfaceType> x:
            slice<ast.Expr> types = default;
            slice<ptr<ast.Field>> methods = default;
            foreach (var (_, f) in x.Methods.List) {
                if (len(f.Names) > 1 && f.Names[0].Name == "type") { 
                    // type list type
                    types = append(types, f.Type);

                }
                else
 { 
                    // method or embedded interface
                    methods = append(methods, f);

                }

            }
            buf.WriteString("interface{");
            writeFieldList(_addr_buf, methods, "; ", true);
            if (len(types) > 0) {
                if (len(methods) > 0) {
                    buf.WriteString("; ");
                }
                buf.WriteString("type ");
                writeExprList(_addr_buf, types);
            }

            buf.WriteByte('}');
            break;
        case ptr<ast.MapType> x:
            buf.WriteString("map[");
            WriteExpr(_addr_buf, x.Key);
            buf.WriteByte(']');
            WriteExpr(_addr_buf, x.Value);
            break;
        case ptr<ast.ChanType> x:
            @string s = default;

            if (x.Dir == ast.SEND) 
                s = "chan<- ";
            else if (x.Dir == ast.RECV) 
                s = "<-chan ";
            else 
                s = "chan ";
                        buf.WriteString(s);
            WriteExpr(_addr_buf, x.Value);
            break;
        default:
        {
            var x = x.type();
            buf.WriteString(fmt.Sprintf("(ast: %T)", x)); // nil, ast.BadExpr, ast.KeyValueExpr
            break;
        }
    }

}

private static void writeSigExpr(ptr<bytes.Buffer> _addr_buf, ptr<ast.FuncType> _addr_sig) {
    ref bytes.Buffer buf = ref _addr_buf.val;
    ref ast.FuncType sig = ref _addr_sig.val;

    buf.WriteByte('(');
    writeFieldList(_addr_buf, sig.Params.List, ", ", false);
    buf.WriteByte(')');

    var res = sig.Results;
    var n = res.NumFields();
    if (n == 0) { 
        // no result
        return ;

    }
    buf.WriteByte(' ');
    if (n == 1 && len(res.List[0].Names) == 0) { 
        // single unnamed result
        WriteExpr(_addr_buf, res.List[0].Type);
        return ;

    }
    buf.WriteByte('(');
    writeFieldList(_addr_buf, res.List, ", ", false);
    buf.WriteByte(')');

}

private static void writeFieldList(ptr<bytes.Buffer> _addr_buf, slice<ptr<ast.Field>> list, @string sep, bool iface) {
    ref bytes.Buffer buf = ref _addr_buf.val;

    foreach (var (i, f) in list) {
        if (i > 0) {
            buf.WriteString(sep);
        }
        writeIdentList(_addr_buf, f.Names); 

        // types of interface methods consist of signatures only
        {
            ptr<ast.FuncType> (sig, _) = f.Type._<ptr<ast.FuncType>>();

            if (sig != null && iface) {
                writeSigExpr(_addr_buf, sig);
                continue;
            } 

            // named fields are separated with a blank from the field type

        } 

        // named fields are separated with a blank from the field type
        if (len(f.Names) > 0) {
            buf.WriteByte(' ');
        }
        WriteExpr(_addr_buf, f.Type); 

        // ignore tag
    }
}

private static void writeIdentList(ptr<bytes.Buffer> _addr_buf, slice<ptr<ast.Ident>> list) {
    ref bytes.Buffer buf = ref _addr_buf.val;

    foreach (var (i, x) in list) {
        if (i > 0) {
            buf.WriteString(", ");
        }
        buf.WriteString(x.Name);

    }
}

private static void writeExprList(ptr<bytes.Buffer> _addr_buf, slice<ast.Expr> list) {
    ref bytes.Buffer buf = ref _addr_buf.val;

    foreach (var (i, x) in list) {
        if (i > 0) {
            buf.WriteString(", ");
        }
        WriteExpr(_addr_buf, x);

    }
}

} // end types_package
