//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ast = go.go.ast_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace ast
{
    public static partial class inspector_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct @event
        {
            // Constructors
            public @event(NilType _)
            {
                this.node = default;
                this.typ = default;
                this.index = default;
            }

            public @event(ast.Node node = default, ulong typ = default, nint index = default)
            {
                this.node = node;
                this.typ = typ;
                this.index = index;
            }

            // Enable comparisons between nil and @event struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(@event value, NilType nil) => value.Equals(default(@event));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(@event value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, @event value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, @event value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @event(NilType nil) => default(@event);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static @event @event_cast(dynamic value)
        {
            return new @event(value.node, value.typ, value.index);
        }
    }
}}}}}}}}