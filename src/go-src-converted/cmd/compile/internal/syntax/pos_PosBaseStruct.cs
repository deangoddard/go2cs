//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:26:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct PosBase
        {
            // Constructors
            public PosBase(NilType _)
            {
                this.pos = default;
                this.filename = default;
                this.line = default;
                this.col = default;
            }

            public PosBase(Pos pos = default, @string filename = default, uint line = default, uint col = default)
            {
                this.pos = pos;
                this.filename = filename;
                this.line = line;
                this.col = col;
            }

            // Enable comparisons between nil and PosBase struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PosBase value, NilType nil) => value.Equals(default(PosBase));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PosBase value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PosBase value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PosBase value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PosBase(NilType nil) => default(PosBase);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PosBase PosBase_cast(dynamic value)
        {
            return new PosBase(value.pos, value.filename, value.line, value.col);
        }
    }
}}}}