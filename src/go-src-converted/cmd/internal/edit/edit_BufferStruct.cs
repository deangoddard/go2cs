//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:23:46 UTC
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
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class edit_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Buffer
        {
            // Constructors
            public Buffer(NilType _)
            {
                this.old = default;
                this.q = default;
            }

            public Buffer(slice<byte> old = default, edits q = default)
            {
                this.old = old;
                this.q = q;
            }

            // Enable comparisons between nil and Buffer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Buffer value, NilType nil) => value.Equals(default(Buffer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Buffer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Buffer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Buffer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Buffer(NilType nil) => default(Buffer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Buffer Buffer_cast(dynamic value)
        {
            return new Buffer(value.old, value.q);
        }
    }
}}}