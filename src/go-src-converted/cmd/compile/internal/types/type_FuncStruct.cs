//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:24:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Func
        {
            // Constructors
            public Func(NilType _)
            {
                this.Receiver = default;
                this.Results = default;
                this.Params = default;
                this.Nname = default;
                this.pkg = default;
                this.Argwid = default;
                this.Outnamed = default;
            }

            public Func(ref ptr<Type> Receiver = default, ref ptr<Type> Results = default, ref ptr<Type> Params = default, ref ptr<Node> Nname = default, ref ptr<Pkg> pkg = default, long Argwid = default, bool Outnamed = default)
            {
                this.Receiver = Receiver;
                this.Results = Results;
                this.Params = Params;
                this.Nname = Nname;
                this.pkg = pkg;
                this.Argwid = Argwid;
                this.Outnamed = Outnamed;
            }

            // Enable comparisons between nil and Func struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Func value, NilType nil) => value.Equals(default(Func));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Func value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Func value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Func value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Func(NilType nil) => default(Func);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Func Func_cast(dynamic value)
        {
            return new Func(ref value.Receiver, ref value.Results, ref value.Params, ref value.Nname, ref value.pkg, value.Argwid, value.Outnamed);
        }
    }
}}}}