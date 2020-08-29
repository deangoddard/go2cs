// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package types -- go2cs converted at 2020 August 29 08:47:41 UTC
// import "go/types" ==> using types = go.go.types_package
// Original source: C:\Go\src\go\types\labels.go
using ast = go.go.ast_package;
using token = go.go.token_package;
using static go.builtin;
using System;

namespace go {
namespace go
{
    public static partial class types_package
    {
        // labels checks correct label use in body.
        private static void labels(this ref Checker check, ref ast.BlockStmt body)
        { 
            // set of all labels in this body
            var all = NewScope(null, body.Pos(), body.End(), "label");

            var fwdJumps = check.blockBranches(all, null, null, body.List); 

            // If there are any forward jumps left, no label was found for
            // the corresponding goto statements. Either those labels were
            // never defined, or they are inside blocks and not reachable
            // for the respective gotos.
            foreach (var (_, jmp) in fwdJumps)
            {
                @string msg = default;
                var name = jmp.Label.Name;
                {
                    var alt = all.Lookup(name);

                    if (alt != null)
                    {
                        msg = "goto %s jumps into block";
                        alt._<ref Label>().used = true; // avoid another error
                    }
                    else
                    {
                        msg = "label %s not declared";
                    }
                }
                check.errorf(jmp.Label.Pos(), msg, name);
            }            foreach (var (_, obj) in all.elems)
            {
                {
                    ref Label lbl = obj._<ref Label>();

                    if (!lbl.used)
                    {
                        check.softErrorf(lbl.pos, "label %s declared but not used", lbl.name);
                    }
                }
            }
        }

        // A block tracks label declarations in a block and its enclosing blocks.
        private partial struct block
        {
            public ptr<block> parent; // enclosing block
            public ptr<ast.LabeledStmt> lstmt; // labeled statement to which this block belongs, or nil
            public map<@string, ref ast.LabeledStmt> labels; // allocated lazily
        }

        // insert records a new label declaration for the current block.
        // The label must not have been declared before in any block.
        private static void insert(this ref block b, ref ast.LabeledStmt s)
        {
            var name = s.Label.Name;
            if (debug)
            {
                assert(b.gotoTarget(name) == null);
            }
            var labels = b.labels;
            if (labels == null)
            {
                labels = make_map<@string, ref ast.LabeledStmt>();
                b.labels = labels;
            }
            labels[name] = s;
        }

        // gotoTarget returns the labeled statement in the current
        // or an enclosing block with the given label name, or nil.
        private static ref ast.LabeledStmt gotoTarget(this ref block b, @string name)
        {
            {
                var s = b;

                while (s != null)
                {
                    {
                        var t = s.labels[name];

                        if (t != null)
                        {
                            return t;
                    s = s.parent;
                        }

                    }
                }

            }
            return null;
        }

        // enclosingTarget returns the innermost enclosing labeled
        // statement with the given label name, or nil.
        private static ref ast.LabeledStmt enclosingTarget(this ref block b, @string name)
        {
            {
                var s = b;

                while (s != null)
                {
                    {
                        var t = s.lstmt;

                        if (t != null && t.Label.Name == name)
                        {
                            return t;
                    s = s.parent;
                        }

                    }
                }

            }
            return null;
        }

        // blockBranches processes a block's statement list and returns the set of outgoing forward jumps.
        // all is the scope of all declared labels, parent the set of labels declared in the immediately
        // enclosing block, and lstmt is the labeled statement this block is associated with (or nil).
        private static slice<ref ast.BranchStmt> blockBranches(this ref Checker check, ref Scope all, ref block parent, ref ast.LabeledStmt lstmt, slice<ast.Stmt> list)
        {
            block b = ref new block(parent:parent,lstmt:lstmt);

            token.Pos varDeclPos = default;            slice<ref ast.BranchStmt> fwdJumps = default;            slice<ref ast.BranchStmt> badJumps = default; 

            // All forward jumps jumping over a variable declaration are possibly
            // invalid (they may still jump out of the block and be ok).
            // recordVarDecl records them for the given position.
            Action<token.Pos> recordVarDecl = pos =>
            {
                varDeclPos = pos;
                badJumps = append(badJumps[..0L], fwdJumps); // copy fwdJumps to badJumps
            }
;

            Func<ref ast.BranchStmt, bool> jumpsOverVarDecl = jmp =>
            {
                if (varDeclPos.IsValid())
                {
                    foreach (var (_, bad) in badJumps)
                    {
                        if (jmp == bad)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
;

            Action<ref ast.LabeledStmt, slice<ast.Stmt>> blockBranches = (lstmt, list) =>
            { 
                // Unresolved forward jumps inside the nested block
                // become forward jumps in the current block.
                fwdJumps = append(fwdJumps, check.blockBranches(all, b, lstmt, list));
            }
;

            Action<ast.Stmt> stmtBranches = default;
            stmtBranches = s =>
            {
                switch (s.type())
                {
                    case ref ast.DeclStmt s:
                        {
                            ref ast.GenDecl (d, _) = s.Decl._<ref ast.GenDecl>();

                            if (d != null && d.Tok == token.VAR)
                            {
                                recordVarDecl(d.Pos());
                            }

                        }
                        break;
                    case ref ast.LabeledStmt s:
                        {
                            var name__prev1 = name;

                            var name = s.Label.Name;

                            if (name != "_")
                            {
                                var lbl = NewLabel(s.Label.Pos(), check.pkg, name);
                                {
                                    var alt = all.Insert(lbl);

                                    if (alt != null)
                                    {
                                        check.softErrorf(lbl.pos, "label %s already declared", name);
                                        check.reportAltDecl(alt); 
                                        // ok to continue
                                    }
                                    else
                                    {
                                        b.insert(s);
                                        check.recordDef(s.Label, lbl);
                                    } 
                                    // resolve matching forward jumps and remove them from fwdJumps

                                } 
                                // resolve matching forward jumps and remove them from fwdJumps
                                long i = 0L;
                                foreach (var (_, jmp) in fwdJumps)
                                {
                                    if (jmp.Label.Name == name)
                                    { 
                                        // match
                                        lbl.used = true;
                                        check.recordUse(jmp.Label, lbl);
                                        if (jumpsOverVarDecl(jmp))
                                        {
                                            check.softErrorf(jmp.Label.Pos(), "goto %s jumps over variable declaration at line %d", name, check.fset.Position(varDeclPos).Line); 
                                            // ok to continue
                                        }
                                    }
                                    else
                                    { 
                                        // no match - record new forward jump
                                        fwdJumps[i] = jmp;
                                        i++;
                                    }
                                }
                                fwdJumps = fwdJumps[..i];
                                lstmt = s;
                            }

                            name = name__prev1;

                        }
                        stmtBranches(s.Stmt);
                        break;
                    case ref ast.BranchStmt s:
                        if (s.Label == null)
                        {
                            return; // checked in 1st pass (check.stmt)
                        } 

                        // determine and validate target
                        name = s.Label.Name;

                        if (s.Tok == token.BREAK) 
                            // spec: "If there is a label, it must be that of an enclosing
                            // "for", "switch", or "select" statement, and that is the one
                            // whose execution terminates."
                            var valid = false;
                            {
                                var t__prev1 = t;

                                var t = b.enclosingTarget(name);

                                if (t != null)
                                {
                                    switch (t.Stmt.type())
                                    {
                                        case ref ast.SwitchStmt _:
                                            valid = true;
                                            break;
                                        case ref ast.TypeSwitchStmt _:
                                            valid = true;
                                            break;
                                        case ref ast.SelectStmt _:
                                            valid = true;
                                            break;
                                        case ref ast.ForStmt _:
                                            valid = true;
                                            break;
                                        case ref ast.RangeStmt _:
                                            valid = true;
                                            break;
                                    }
                                }

                                t = t__prev1;

                            }
                            if (!valid)
                            {
                                check.errorf(s.Label.Pos(), "invalid break label %s", name);
                                return;
                            }
                        else if (s.Tok == token.CONTINUE) 
                            // spec: "If there is a label, it must be that of an enclosing
                            // "for" statement, and that is the one whose execution advances."
                            valid = false;
                            {
                                var t__prev1 = t;

                                t = b.enclosingTarget(name);

                                if (t != null)
                                {
                                    switch (t.Stmt.type())
                                    {
                                        case ref ast.ForStmt _:
                                            valid = true;
                                            break;
                                        case ref ast.RangeStmt _:
                                            valid = true;
                                            break;
                                    }
                                }

                                t = t__prev1;

                            }
                            if (!valid)
                            {
                                check.errorf(s.Label.Pos(), "invalid continue label %s", name);
                                return;
                            }
                        else if (s.Tok == token.GOTO) 
                            if (b.gotoTarget(name) == null)
                            { 
                                // label may be declared later - add branch to forward jumps
                                fwdJumps = append(fwdJumps, s);
                                return;
                            }
                        else 
                            check.invalidAST(s.Pos(), "branch statement: %s %s", s.Tok, name);
                            return;
                        // record label use
                        var obj = all.Lookup(name);
                        obj._<ref Label>().used = true;
                        check.recordUse(s.Label, obj);
                        break;
                    case ref ast.AssignStmt s:
                        if (s.Tok == token.DEFINE)
                        {
                            recordVarDecl(s.Pos());
                        }
                        break;
                    case ref ast.BlockStmt s:
                        blockBranches(lstmt, s.List);
                        break;
                    case ref ast.IfStmt s:
                        stmtBranches(s.Body);
                        if (s.Else != null)
                        {
                            stmtBranches(s.Else);
                        }
                        break;
                    case ref ast.CaseClause s:
                        blockBranches(null, s.Body);
                        break;
                    case ref ast.SwitchStmt s:
                        stmtBranches(s.Body);
                        break;
                    case ref ast.TypeSwitchStmt s:
                        stmtBranches(s.Body);
                        break;
                    case ref ast.CommClause s:
                        blockBranches(null, s.Body);
                        break;
                    case ref ast.SelectStmt s:
                        stmtBranches(s.Body);
                        break;
                    case ref ast.ForStmt s:
                        stmtBranches(s.Body);
                        break;
                    case ref ast.RangeStmt s:
                        stmtBranches(s.Body);
                        break;
                }
            }
;

            {
                var s__prev1 = s;

                foreach (var (_, __s) in list)
                {
                    s = __s;
                    stmtBranches(s);
                }

                s = s__prev1;
            }

            return fwdJumps;
        }
    }
}}
