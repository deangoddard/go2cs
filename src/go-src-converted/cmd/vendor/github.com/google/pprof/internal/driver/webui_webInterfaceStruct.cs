//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using template = go.html.template_package;
using net = go.net_package;
using http = go.net.http_package;
using gourl = go.net.url_package;
using os = go.os_package;
using exec = go.os.exec_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using graph = go.github.com.google.pprof.@internal.graph_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using report = go.github.com.google.pprof.@internal.report_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct webInterface
        {
            // Constructors
            public webInterface(NilType _)
            {
                this.prof = default;
                this.options = default;
                this.help = default;
                this.templates = default;
                this.settingsFile = default;
            }

            public webInterface(ref ptr<profile.Profile> prof = default, ref ptr<plugin.Options> options = default, map<@string, @string> help = default, ref ptr<template.Template> templates = default, @string settingsFile = default)
            {
                this.prof = prof;
                this.options = options;
                this.help = help;
                this.templates = templates;
                this.settingsFile = settingsFile;
            }

            // Enable comparisons between nil and webInterface struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(webInterface value, NilType nil) => value.Equals(default(webInterface));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(webInterface value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, webInterface value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, webInterface value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator webInterface(NilType nil) => default(webInterface);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static webInterface webInterface_cast(dynamic value)
        {
            return new webInterface(ref value.prof, ref value.options, value.help, ref value.templates, value.settingsFile);
        }
    }
}}}}}}}