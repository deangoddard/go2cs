//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace text
{
    public static partial class tabwriter_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct cell
        {
            // Constructors
            public cell(NilType _)
            {
                this.size = default;
                this.width = default;
                this.htab = default;
            }

            public cell(nint size = default, nint width = default, bool htab = default)
            {
                this.size = size;
                this.width = width;
                this.htab = htab;
            }

            // Enable comparisons between nil and cell struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cell value, NilType nil) => value.Equals(default(cell));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cell value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cell value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cell value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cell(NilType nil) => default(cell);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static cell cell_cast(dynamic value)
        {
            return new cell(value.size, value.width, value.htab);
        }
    }
}}