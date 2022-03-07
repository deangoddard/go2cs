// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Package astutil contains common utilities for working with the Go AST.
// package astutil -- go2cs converted at 2022 March 06 23:09:34 UTC
// import "golang.org/x/tools/go/ast/astutil" ==> using astutil = go.golang.org.x.tools.go.ast.astutil_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\tools\go\ast\astutil\imports.go
// import "golang.org/x/tools/go/ast/astutil"

using fmt = go.fmt_package;
using ast = go.go.ast_package;
using token = go.go.token_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using System;


namespace go.golang.org.x.tools.go.ast;

public static partial class astutil_package {

    // AddImport adds the import path to the file f, if absent.
public static bool AddImport(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_f, @string path) {
    bool added = default;
    ref token.FileSet fset = ref _addr_fset.val;
    ref ast.File f = ref _addr_f.val;

    return AddNamedImport(_addr_fset, _addr_f, "", path);
}

// AddNamedImport adds the import with the given name and path to the file f, if absent.
// If name is not empty, it is used to rename the import.
//
// For example, calling
//    AddNamedImport(fset, f, "pathpkg", "path")
// adds
//    import pathpkg "path"
public static bool AddNamedImport(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_f, @string name, @string path) {
    bool added = default;
    ref token.FileSet fset = ref _addr_fset.val;
    ref ast.File f = ref _addr_f.val;

    if (imports(_addr_f, name, path)) {
        return false;
    }
    ptr<ast.ImportSpec> newImport = addr(new ast.ImportSpec(Path:&ast.BasicLit{Kind:token.STRING,Value:strconv.Quote(path),},));
    if (name != "") {
        newImport.Name = addr(new ast.Ident(Name:name));
    }
    nint bestMatch = -1;    nint lastImport = -1;    ptr<ast.GenDecl> impDecl;    nint impIndex = -1;    var isThirdPartyPath = isThirdParty(path);
    {
        var i__prev1 = i;
        var decl__prev1 = decl;

        foreach (var (__i, __decl) in f.Decls) {
            i = __i;
            decl = __decl;
            ptr<ast.GenDecl> (gen, ok) = decl._<ptr<ast.GenDecl>>();
            if (ok && gen.Tok == token.IMPORT) {
                lastImport = i; 
                // Do not add to import "C", to avoid disrupting the
                // association with its doc comment, breaking cgo.
                if (declImports(gen, "C")) {
                    continue;
                } 

                // Match an empty import decl if that's all that is available.
                if (len(gen.Specs) == 0 && bestMatch == -1) {
                    impDecl = gen;
                } 

                // Compute longest shared prefix with imports in this group and find best
                // matched import spec.
                // 1. Always prefer import spec with longest shared prefix.
                // 2. While match length is 0,
                // - for stdlib package: prefer first import spec.
                // - for third party package: prefer first third party import spec.
                // We cannot use last import spec as best match for third party package
                // because grouped imports are usually placed last by goimports -local
                // flag.
                // See issue #19190.
                var seenAnyThirdParty = false;
                {
                    var spec__prev2 = spec;

                    foreach (var (__j, __spec) in gen.Specs) {
                        j = __j;
                        spec = __spec;
                        ptr<ast.ImportSpec> impspec = spec._<ptr<ast.ImportSpec>>();
                        var p = importPath(impspec);
                        var n = matchLen(p, path);
                        if (n > bestMatch || (bestMatch == 0 && !seenAnyThirdParty && isThirdPartyPath)) {
                            bestMatch = n;
                            impDecl = gen;
                            impIndex = j;
                        }
                        seenAnyThirdParty = seenAnyThirdParty || isThirdParty(p);
                    }

                    spec = spec__prev2;
                }
            }

        }
        i = i__prev1;
        decl = decl__prev1;
    }

    if (impDecl == null) {
        impDecl = addr(new ast.GenDecl(Tok:token.IMPORT,));
        if (lastImport >= 0) {
            impDecl.TokPos = f.Decls[lastImport].End();
        }
        else
 { 
            // There are no existing imports.
            // Our new import, preceded by a blank line,  goes after the package declaration
            // and after the comment, if any, that starts on the same line as the
            // package declaration.
            impDecl.TokPos = f.Package;

            var file = fset.File(f.Package);
            var pkgLine = file.Line(f.Package);
            foreach (var (_, c) in f.Comments) {
                if (file.Line(c.Pos()) > pkgLine) {
                    break;
                } 
                // +2 for a blank line
                impDecl.TokPos = c.End() + 2;

            }

        }
        f.Decls = append(f.Decls, null);
        copy(f.Decls[(int)lastImport + 2..], f.Decls[(int)lastImport + 1..]);
        f.Decls[lastImport + 1] = impDecl;

    }
    nint insertAt = 0;
    if (impIndex >= 0) { 
        // insert after the found import
        insertAt = impIndex + 1;

    }
    impDecl.Specs = append(impDecl.Specs, null);
    copy(impDecl.Specs[(int)insertAt + 1..], impDecl.Specs[(int)insertAt..]);
    impDecl.Specs[insertAt] = newImport;
    var pos = impDecl.Pos();
    if (insertAt > 0) { 
        // If there is a comment after an existing import, preserve the comment
        // position by adding the new import after the comment.
        {
            var spec__prev2 = spec;

            ptr<ast.ImportSpec> (spec, ok) = impDecl.Specs[insertAt - 1]._<ptr<ast.ImportSpec>>();

            if (ok && spec.Comment != null) {
                pos = spec.Comment.End();
            }
            else
 { 
                // Assign same position as the previous import,
                // so that the sorter sees it as being in the same block.
                pos = impDecl.Specs[insertAt - 1].Pos();

            }

            spec = spec__prev2;

        }

    }
    if (newImport.Name != null) {
        newImport.Name.NamePos = pos;
    }
    newImport.Path.ValuePos = pos;
    newImport.EndPos = pos; 

    // Clean up parens. impDecl contains at least one spec.
    if (len(impDecl.Specs) == 1) { 
        // Remove unneeded parens.
        impDecl.Lparen = token.NoPos;

    }
    else if (!impDecl.Lparen.IsValid()) { 
        // impDecl needs parens added.
        impDecl.Lparen = impDecl.Specs[0].Pos();

    }
    f.Imports = append(f.Imports, newImport);

    if (len(f.Decls) <= 1) {
        return true;
    }
    ptr<ast.GenDecl> first;
    {
        var i__prev1 = i;

        for (nint i = 0; i < len(f.Decls); i++) {
            var decl = f.Decls[i];
            (gen, ok) = decl._<ptr<ast.GenDecl>>();
            if (!ok || gen.Tok != token.IMPORT || declImports(gen, "C")) {
                continue;
            }
            if (first == null) {
                first = gen;
                continue; // Don't touch the first one.
            } 
            // We now know there is more than one package in this import
            // declaration. Ensure that it ends up parenthesized.
            first.Lparen = first.Pos(); 
            // Move the imports of the other import declaration to the first one.
            {
                var spec__prev2 = spec;

                foreach (var (_, __spec) in gen.Specs) {
                    spec = __spec;
                    spec._<ptr<ast.ImportSpec>>().Path.ValuePos = first.Pos();
                    first.Specs = append(first.Specs, spec);
                }

                spec = spec__prev2;
            }

            f.Decls = append(f.Decls[..(int)i], f.Decls[(int)i + 1..]);
            i--;

        }

        i = i__prev1;
    }

    return true;

}

private static bool isThirdParty(@string importPath) { 
    // Third party package import path usually contains "." (".com", ".org", ...)
    // This logic is taken from golang.org/x/tools/imports package.
    return strings.Contains(importPath, ".");

}

// DeleteImport deletes the import path from the file f, if present.
// If there are duplicate import declarations, all matching ones are deleted.
public static bool DeleteImport(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_f, @string path) {
    bool deleted = default;
    ref token.FileSet fset = ref _addr_fset.val;
    ref ast.File f = ref _addr_f.val;

    return DeleteNamedImport(_addr_fset, _addr_f, "", path);
}

// DeleteNamedImport deletes the import with the given name and path from the file f, if present.
// If there are duplicate import declarations, all matching ones are deleted.
public static bool DeleteNamedImport(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_f, @string name, @string path) => func((_, panic, _) => {
    bool deleted = default;
    ref token.FileSet fset = ref _addr_fset.val;
    ref ast.File f = ref _addr_f.val;

    slice<ptr<ast.ImportSpec>> delspecs = default;
    slice<ptr<ast.CommentGroup>> delcomments = default; 

    // Find the import nodes that import path, if any.
    {
        nint i__prev1 = i;

        for (nint i = 0; i < len(f.Decls); i++) {
            var decl = f.Decls[i];
            ptr<ast.GenDecl> (gen, ok) = decl._<ptr<ast.GenDecl>>();
            if (!ok || gen.Tok != token.IMPORT) {
                continue;
            }
            {
                nint j__prev2 = j;

                for (nint j = 0; j < len(gen.Specs); j++) {
                    var spec = gen.Specs[j];
                    ptr<ast.ImportSpec> impspec = spec._<ptr<ast.ImportSpec>>();
                    if (importName(impspec) != name || importPath(impspec) != path) {
                        continue;
                    } 

                    // We found an import spec that imports path.
                    // Delete it.
                    delspecs = append(delspecs, impspec);
                    deleted = true;
                    copy(gen.Specs[(int)j..], gen.Specs[(int)j + 1..]);
                    gen.Specs = gen.Specs[..(int)len(gen.Specs) - 1]; 

                    // If this was the last import spec in this decl,
                    // delete the decl, too.
                    if (len(gen.Specs) == 0) {
                        copy(f.Decls[(int)i..], f.Decls[(int)i + 1..]);
                        f.Decls = f.Decls[..(int)len(f.Decls) - 1];
                        i--;
                        break;
                    }
                    else if (len(gen.Specs) == 1) {
                        if (impspec.Doc != null) {
                            delcomments = append(delcomments, impspec.Doc);
                        }
                        if (impspec.Comment != null) {
                            delcomments = append(delcomments, impspec.Comment);
                        }
                        {
                            var cg__prev3 = cg;

                            foreach (var (_, __cg) in f.Comments) {
                                cg = __cg; 
                                // Found comment on the same line as the import spec.
                                if (cg.End() < impspec.Pos() && fset.Position(cg.End()).Line == fset.Position(impspec.Pos()).Line) {
                                    delcomments = append(delcomments, cg);
                                    break;
                                }

                            }

                            cg = cg__prev3;
                        }

                        spec = gen.Specs[0]._<ptr<ast.ImportSpec>>(); 

                        // Move the documentation right after the import decl.
                        if (spec.Doc != null) {
                            while (fset.Position(gen.TokPos).Line + 1 < fset.Position(spec.Doc.Pos()).Line) {
                                fset.File(gen.TokPos).MergeLine(fset.Position(gen.TokPos).Line);
                            }
                        }

                        {
                            var cg__prev3 = cg;

                            foreach (var (_, __cg) in f.Comments) {
                                cg = __cg;
                                if (cg.End() < spec.Pos() && fset.Position(cg.End()).Line == fset.Position(spec.Pos()).Line) {
                                    while (fset.Position(gen.TokPos).Line + 1 < fset.Position(spec.Pos()).Line) {
                                        fset.File(gen.TokPos).MergeLine(fset.Position(gen.TokPos).Line);
                                    }

                                    break;
                                }
                            }

                            cg = cg__prev3;
                        }
                    }

                    if (j > 0) {
                        ptr<ast.ImportSpec> lastImpspec = gen.Specs[j - 1]._<ptr<ast.ImportSpec>>();
                        var lastLine = fset.Position(lastImpspec.Path.ValuePos).Line;
                        var line = fset.Position(impspec.Path.ValuePos).Line; 

                        // We deleted an entry but now there may be
                        // a blank line-sized hole where the import was.
                        if (line - lastLine > 1 || !gen.Rparen.IsValid()) { 
                            // There was a blank line immediately preceding the deleted import,
                            // so there's no need to close the hole. The right parenthesis is
                            // invalid after AddImport to an import statement without parenthesis.
                            // Do nothing.
                        }
                        else if (line != fset.File(gen.Rparen).LineCount()) { 
                            // There was no blank line. Close the hole.
                            fset.File(gen.Rparen).MergeLine(line);

                        }

                    }

                    j--;

                }


                j = j__prev2;
            }

        }

        i = i__prev1;
    } 

    // Delete imports from f.Imports.
    {
        nint i__prev1 = i;

        for (i = 0; i < len(f.Imports); i++) {
            var imp = f.Imports[i];
            {
                nint j__prev2 = j;
                var del__prev2 = del;

                foreach (var (__j, __del) in delspecs) {
                    j = __j;
                    del = __del;
                    if (imp == del) {
                        copy(f.Imports[(int)i..], f.Imports[(int)i + 1..]);
                        f.Imports = f.Imports[..(int)len(f.Imports) - 1];
                        copy(delspecs[(int)j..], delspecs[(int)j + 1..]);
                        delspecs = delspecs[..(int)len(delspecs) - 1];
                        i--;
                        break;
                    }
                }

                j = j__prev2;
                del = del__prev2;
            }
        }

        i = i__prev1;
    } 

    // Delete comments from f.Comments.
    {
        nint i__prev1 = i;

        for (i = 0; i < len(f.Comments); i++) {
            var cg = f.Comments[i];
            {
                nint j__prev2 = j;
                var del__prev2 = del;

                foreach (var (__j, __del) in delcomments) {
                    j = __j;
                    del = __del;
                    if (cg == del) {
                        copy(f.Comments[(int)i..], f.Comments[(int)i + 1..]);
                        f.Comments = f.Comments[..(int)len(f.Comments) - 1];
                        copy(delcomments[(int)j..], delcomments[(int)j + 1..]);
                        delcomments = delcomments[..(int)len(delcomments) - 1];
                        i--;
                        break;
                    }
                }

                j = j__prev2;
                del = del__prev2;
            }
        }

        i = i__prev1;
    }

    if (len(delspecs) > 0) {
        panic(fmt.Sprintf("deleted specs from Decls but not Imports: %v", delspecs));
    }
    return ;

});

// RewriteImport rewrites any import of path oldPath to path newPath.
public static bool RewriteImport(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_f, @string oldPath, @string newPath) {
    bool rewrote = default;
    ref token.FileSet fset = ref _addr_fset.val;
    ref ast.File f = ref _addr_f.val;

    foreach (var (_, imp) in f.Imports) {
        if (importPath(_addr_imp) == oldPath) {
            rewrote = true; 
            // record old End, because the default is to compute
            // it using the length of imp.Path.Value.
            imp.EndPos = imp.End();
            imp.Path.Value = strconv.Quote(newPath);

        }
    }    return ;

}

// UsesImport reports whether a given import is used.
public static bool UsesImport(ptr<ast.File> _addr_f, @string path) {
    bool used = default;
    ref ast.File f = ref _addr_f.val;

    var spec = importSpec(_addr_f, path);
    if (spec == null) {
        return ;
    }
    var name = spec.Name.String();
    switch (name) {
        case "<nil>": 
            // If the package name is not explicitly specified,
            // make an educated guess. This is not guaranteed to be correct.
                   var lastSlash = strings.LastIndex(path, "/");
                   if (lastSlash == -1) {
                       name = path;
                   }
                   else
            {
                       name = path[(int)lastSlash + 1..];
                   }
            break;
        case "_": 
            // Not sure if this import is used - err on the side of caution.

        case ".": 
            // Not sure if this import is used - err on the side of caution.
            return true;
            break;
    }

    ast.Walk(visitFn(n => {
        ptr<ast.SelectorExpr> (sel, ok) = n._<ptr<ast.SelectorExpr>>();
        if (ok && isTopName(sel.X, name)) {
            used = true;
        }
    }), f);

    return ;

}

public delegate void visitFn(ast.Node);

private static ast.Visitor Visit(this visitFn fn, ast.Node node) {
    fn(node);
    return fn;
}

// imports reports whether f has an import with the specified name and path.
private static bool imports(ptr<ast.File> _addr_f, @string name, @string path) {
    ref ast.File f = ref _addr_f.val;

    foreach (var (_, s) in f.Imports) {
        if (importName(_addr_s) == name && importPath(_addr_s) == path) {
            return true;
        }
    }    return false;

}

// importSpec returns the import spec if f imports path,
// or nil otherwise.
private static ptr<ast.ImportSpec> importSpec(ptr<ast.File> _addr_f, @string path) {
    ref ast.File f = ref _addr_f.val;

    foreach (var (_, s) in f.Imports) {
        if (importPath(_addr_s) == path) {
            return _addr_s!;
        }
    }    return _addr_null!;

}

// importName returns the name of s,
// or "" if the import is not named.
private static @string importName(ptr<ast.ImportSpec> _addr_s) {
    ref ast.ImportSpec s = ref _addr_s.val;

    if (s.Name == null) {
        return "";
    }
    return s.Name.Name;

}

// importPath returns the unquoted import path of s,
// or "" if the path is not properly quoted.
private static @string importPath(ptr<ast.ImportSpec> _addr_s) {
    ref ast.ImportSpec s = ref _addr_s.val;

    var (t, err) = strconv.Unquote(s.Path.Value);
    if (err != null) {
        return "";
    }
    return t;

}

// declImports reports whether gen contains an import of path.
private static bool declImports(ptr<ast.GenDecl> _addr_gen, @string path) {
    ref ast.GenDecl gen = ref _addr_gen.val;

    if (gen.Tok != token.IMPORT) {
        return false;
    }
    foreach (var (_, spec) in gen.Specs) {
        ptr<ast.ImportSpec> impspec = spec._<ptr<ast.ImportSpec>>();
        if (importPath(impspec) == path) {
            return true;
        }
    }    return false;

}

// matchLen returns the length of the longest path segment prefix shared by x and y.
private static nint matchLen(@string x, @string y) {
    nint n = 0;
    for (nint i = 0; i < len(x) && i < len(y) && x[i] == y[i]; i++) {
        if (x[i] == '/') {
            n++;
        }
    }
    return n;

}

// isTopName returns true if n is a top-level unresolved identifier with the given name.
private static bool isTopName(ast.Expr n, @string name) {
    ptr<ast.Ident> (id, ok) = n._<ptr<ast.Ident>>();
    return ok && id.Name == name && id.Obj == null;
}

// Imports returns the file imports grouped by paragraph.
public static slice<slice<ptr<ast.ImportSpec>>> Imports(ptr<token.FileSet> _addr_fset, ptr<ast.File> _addr_f) {
    ref token.FileSet fset = ref _addr_fset.val;
    ref ast.File f = ref _addr_f.val;

    slice<slice<ptr<ast.ImportSpec>>> groups = default;

    foreach (var (_, decl) in f.Decls) {
        ptr<ast.GenDecl> (genDecl, ok) = decl._<ptr<ast.GenDecl>>();
        if (!ok || genDecl.Tok != token.IMPORT) {
            break;
        }
        ptr<ast.ImportSpec> group = new slice<ptr<ast.ImportSpec>>(new ptr<ast.ImportSpec>[] {  });

        nint lastLine = default;
        foreach (var (_, spec) in genDecl.Specs) {
            ptr<ast.ImportSpec> importSpec = spec._<ptr<ast.ImportSpec>>();
            var pos = importSpec.Path.ValuePos;
            var line = fset.Position(pos).Line;
            if (lastLine > 0 && pos > 0 && line - lastLine > 1) {
                groups = append(groups, group);
                group = new slice<ptr<ast.ImportSpec>>(new ptr<ast.ImportSpec>[] {  });
            }
            group = append(group, importSpec);
            lastLine = line;
        }        groups = append(groups, group);

    }    return groups;

}

} // end astutil_package
