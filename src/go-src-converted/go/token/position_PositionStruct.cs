//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class token_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Position
        {
            // Constructors
            public Position(NilType _)
            {
                this.Filename = default;
                this.Offset = default;
                this.Line = default;
                this.Column = default;
            }

            public Position(@string Filename = default, long Offset = default, long Line = default, long Column = default)
            {
                this.Filename = Filename;
                this.Offset = Offset;
                this.Line = Line;
                this.Column = Column;
            }

            // Enable comparisons between nil and Position struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Position value, NilType nil) => value.Equals(default(Position));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Position value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Position value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Position value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Position(NilType nil) => default(Position);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Position Position_cast(dynamic value)
        {
            return new Position(value.Filename, value.Offset, value.Line, value.Column);
        }
    }
}}