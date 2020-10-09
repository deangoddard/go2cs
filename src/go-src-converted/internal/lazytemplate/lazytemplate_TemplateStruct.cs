//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:46:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using sync = go.sync_package;
using template = go.text.template_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class lazytemplate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Template
        {
            // Constructors
            public Template(NilType _)
            {
                this.name = default;
                this.text = default;
                this.once = default;
                this.tmpl = default;
            }

            public Template(@string name = default, @string text = default, sync.Once once = default, ref ptr<template.Template> tmpl = default)
            {
                this.name = name;
                this.text = text;
                this.once = once;
                this.tmpl = tmpl;
            }

            // Enable comparisons between nil and Template struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Template value, NilType nil) => value.Equals(default(Template));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Template value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Template value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Template value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Template(NilType nil) => default(Template);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Template Template_cast(dynamic value)
        {
            return new Template(value.name, value.text, value.once, ref value.tmpl);
        }
    }
}}