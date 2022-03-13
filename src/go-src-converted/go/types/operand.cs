// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// This file defines operands and associated operations.

// package types -- go2cs converted at 2022 March 13 05:53:14 UTC
// import "go/types" ==> using types = go.go.types_package
// Original source: C:\Program Files\Go\src\go\types\operand.go
namespace go.go;

using bytes = bytes_package;
using fmt = fmt_package;
using ast = go.ast_package;
using constant = go.constant_package;
using token = go.token_package;


// An operandMode specifies the (addressing) mode of an operand.

using System;
public static partial class types_package {

private partial struct operandMode { // : byte
}

private static readonly operandMode invalid = iota; // operand is invalid
private static readonly var novalue = 0; // operand represents no value (result of a function call w/o result)
private static readonly var builtin = 1; // operand is a built-in function
private static readonly var typexpr = 2; // operand is a type
private static readonly var constant_ = 3; // operand is a constant; the operand's typ is a Basic type
private static readonly var variable = 4; // operand is an addressable variable
private static readonly var mapindex = 5; // operand is a map index expression (acts like a variable on lhs, commaok on rhs of an assignment)
private static readonly var value = 6; // operand is a computed value
private static readonly var commaok = 7; // like value, but operand may be used in a comma,ok expression
private static readonly var commaerr = 8; // like commaok, but second value is error, not boolean
private static readonly var cgofunc = 9; // operand is a cgo function

private static array<@string> operandModeString = new array<@string>(InitKeyedValues<@string>((invalid, "invalid operand"), (novalue, "no value"), (builtin, "built-in"), (typexpr, "type"), (constant_, "constant"), (variable, "variable"), (mapindex, "map index expression"), (value, "value"), (commaok, "comma, ok expression"), (commaerr, "comma, error expression"), (cgofunc, "cgo function")));

// An operand represents an intermediate value during type checking.
// Operands have an (addressing) mode, the expression evaluating to
// the operand, the operand's type, a value for constants, and an id
// for built-in functions.
// The zero value of operand is a ready to use invalid operand.
//
private partial struct operand {
    public operandMode mode;
    public ast.Expr expr;
    public Type typ;
    public constant.Value val;
    public builtinId id;
}

// Pos returns the position of the expression corresponding to x.
// If x is invalid the position is token.NoPos.
//
private static token.Pos Pos(this ptr<operand> _addr_x) {
    ref operand x = ref _addr_x.val;
 
    // x.expr may not be set if x is invalid
    if (x.expr == null) {
        return token.NoPos;
    }
    return x.expr.Pos();
}

// Operand string formats
// (not all "untyped" cases can appear due to the type system,
// but they fall out naturally here)
//
// mode       format
//
// invalid    <expr> (               <mode>                    )
// novalue    <expr> (               <mode>                    )
// builtin    <expr> (               <mode>                    )
// typexpr    <expr> (               <mode>                    )
//
// constant   <expr> (<untyped kind> <mode>                    )
// constant   <expr> (               <mode>       of type <typ>)
// constant   <expr> (<untyped kind> <mode> <val>              )
// constant   <expr> (               <mode> <val> of type <typ>)
//
// variable   <expr> (<untyped kind> <mode>                    )
// variable   <expr> (               <mode>       of type <typ>)
//
// mapindex   <expr> (<untyped kind> <mode>                    )
// mapindex   <expr> (               <mode>       of type <typ>)
//
// value      <expr> (<untyped kind> <mode>                    )
// value      <expr> (               <mode>       of type <typ>)
//
// commaok    <expr> (<untyped kind> <mode>                    )
// commaok    <expr> (               <mode>       of type <typ>)
//
// commaerr   <expr> (<untyped kind> <mode>                    )
// commaerr   <expr> (               <mode>       of type <typ>)
//
// cgofunc    <expr> (<untyped kind> <mode>                    )
// cgofunc    <expr> (               <mode>       of type <typ>)
//
private static @string operandString(ptr<operand> _addr_x, Qualifier qf) {
    ref operand x = ref _addr_x.val;

    ref bytes.Buffer buf = ref heap(out ptr<bytes.Buffer> _addr_buf);

    @string expr = default;
    if (x.expr != null) {
        expr = ExprString(x.expr);
    }
    else
 {

        if (x.mode == builtin) 
            expr = predeclaredFuncs[x.id].name;
        else if (x.mode == typexpr) 
            expr = TypeString(x.typ, qf);
        else if (x.mode == constant_) 
            expr = x.val.String();
            }
    if (expr != "") {
        buf.WriteString(expr);
        buf.WriteString(" (");
    }
    var hasType = false;

    if (x.mode == invalid || x.mode == novalue || x.mode == builtin || x.mode == typexpr)     else 
        // should have a type, but be cautious (don't crash during printing)
        if (x.typ != null) {
            if (isUntyped(x.typ)) {
                buf.WriteString(x.typ._<ptr<Basic>>().name);
                buf.WriteByte(' ');
                break;
            }
            hasType = true;
        }
    // <mode>
    buf.WriteString(operandModeString[x.mode]); 

    // <val>
    if (x.mode == constant_) {
        {
            var s = x.val.String();

            if (s != expr) {
                buf.WriteByte(' ');
                buf.WriteString(s);
            }

        }
    }
    if (hasType) {
        if (x.typ != Typ[Invalid]) {
            @string intro = default;

            if (isGeneric(x.typ)) 
                intro = " of generic type ";
            else if (asTypeParam(x.typ) != null) 
                intro = " of type parameter type ";
            else 
                intro = " of type ";
                        buf.WriteString(intro);
            WriteType(_addr_buf, x.typ, qf);
        }
        else
 {
            buf.WriteString(" with invalid type");
        }
    }
    if (expr != "") {
        buf.WriteByte(')');
    }
    return buf.String();
}

private static @string String(this ptr<operand> _addr_x) {
    ref operand x = ref _addr_x.val;

    return operandString(_addr_x, null);
}

// setConst sets x to the untyped constant for literal lit.
private static void setConst(this ptr<operand> _addr_x, token.Token tok, @string lit) {
    ref operand x = ref _addr_x.val;

    BasicKind kind = default;

    if (tok == token.INT) 
        kind = UntypedInt;
    else if (tok == token.FLOAT) 
        kind = UntypedFloat;
    else if (tok == token.IMAG) 
        kind = UntypedComplex;
    else if (tok == token.CHAR) 
        kind = UntypedRune;
    else if (tok == token.STRING) 
        kind = UntypedString;
    else 
        unreachable();
        var val = constant.MakeFromLiteral(lit, tok, 0);
    if (val.Kind() == constant.Unknown) {
        x.mode = invalid;
        x.typ = Typ[Invalid];
        return ;
    }
    x.mode = constant_;
    x.typ = Typ[kind];
    x.val = val;
}

// isNil reports whether x is the nil value.
private static bool isNil(this ptr<operand> _addr_x) {
    ref operand x = ref _addr_x.val;

    return x.mode == value && x.typ == Typ[UntypedNil];
}

// assignableTo reports whether x is assignable to a variable of type T. If the
// result is false and a non-nil reason is provided, it may be set to a more
// detailed explanation of the failure (result != ""). The returned error code
// is only valid if the (first) result is false. The check parameter may be nil
// if assignableTo is invoked through an exported API call, i.e., when all
// methods have been type-checked.
private static (bool, errorCode) assignableTo(this ptr<operand> _addr_x, ptr<Checker> _addr_check, Type T, ptr<@string> _addr_reason) {
    bool _p0 = default;
    errorCode _p0 = default;
    ref operand x = ref _addr_x.val;
    ref Checker check = ref _addr_check.val;
    ref @string reason = ref _addr_reason.val;

    if (x.mode == invalid || T == Typ[Invalid]) {
        return (true, 0); // avoid spurious errors
    }
    var V = x.typ; 

    // x's type is identical to T
    if (check.identical(V, T)) {
        return (true, 0);
    }
    var Vu = optype(V);
    var Tu = optype(T); 

    // x is an untyped value representable by a value of type T.
    if (isUntyped(Vu)) {
        {
            ptr<_Sum> (t, ok) = Tu._<ptr<_Sum>>();

            if (ok) {
                return (t.@is(t => { 
                    // TODO(gri) this could probably be more efficient
                    var (ok, _) = x.assignableTo(check, t, reason);
                    return ok;
                }), _IncompatibleAssign);
            }

        }
        var (newType, _, _) = check.implicitTypeAndValue(x, Tu);
        return (newType != null, _IncompatibleAssign);
    }
    if (check.identical(Vu, Tu) && (!isNamed(V) || !isNamed(T))) {
        return (true, 0);
    }
    {
        ptr<Interface> (Ti, ok) = Tu._<ptr<Interface>>();

        if (ok) {
            {
                var (m, wrongType) = check.missingMethod(V, Ti, true);

                if (m != null) {
                    if (reason != null) {
                        if (wrongType != null) {
                            if (check.identical(m.typ, wrongType.typ)) {
                                reason = fmt.Sprintf("missing method %s (%s has pointer receiver)", m.name, m.name);
                            }
                            else
 {
                                reason = fmt.Sprintf("wrong type for method %s (have %s, want %s)", m.Name(), wrongType.typ, m.typ);
                            }
                        }
                        else
 {
                            reason = "missing method " + m.Name();
                        }
                    }
                    return (false, _InvalidIfaceAssign);
                }

            }
            return (true, 0);
        }
    } 

    // x is a bidirectional channel value, T is a channel
    // type, x's type V and T have identical element types,
    // and at least one of V or T is not a named type
    {
        ptr<Chan> (Vc, ok) = Vu._<ptr<Chan>>();

        if (ok && Vc.dir == SendRecv) {
            {
                ptr<Chan> (Tc, ok) = Tu._<ptr<Chan>>();

                if (ok && check.identical(Vc.elem, Tc.elem)) {
                    return (!isNamed(V) || !isNamed(T), _InvalidChanAssign);
                }

            }
        }
    }

    return (false, _IncompatibleAssign);
}

} // end types_package
