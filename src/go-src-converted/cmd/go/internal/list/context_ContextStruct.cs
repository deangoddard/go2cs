//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:16:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using build = go.go.build_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class list_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Context
        {
            // Constructors
            public Context(NilType _)
            {
                this.GOARCH = default;
                this.GOOS = default;
                this.GOROOT = default;
                this.GOPATH = default;
                this.CgoEnabled = default;
                this.UseAllFiles = default;
                this.Compiler = default;
                this.BuildTags = default;
                this.ToolTags = default;
                this.ReleaseTags = default;
                this.InstallSuffix = default;
            }

            public Context(@string GOARCH = default, @string GOOS = default, @string GOROOT = default, @string GOPATH = default, bool CgoEnabled = default, bool UseAllFiles = default, @string Compiler = default, slice<@string> BuildTags = default, slice<@string> ToolTags = default, slice<@string> ReleaseTags = default, @string InstallSuffix = default)
            {
                this.GOARCH = GOARCH;
                this.GOOS = GOOS;
                this.GOROOT = GOROOT;
                this.GOPATH = GOPATH;
                this.CgoEnabled = CgoEnabled;
                this.UseAllFiles = UseAllFiles;
                this.Compiler = Compiler;
                this.BuildTags = BuildTags;
                this.ToolTags = ToolTags;
                this.ReleaseTags = ReleaseTags;
                this.InstallSuffix = InstallSuffix;
            }

            // Enable comparisons between nil and Context struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Context value, NilType nil) => value.Equals(default(Context));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Context value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Context value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Context value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Context(NilType nil) => default(Context);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Context Context_cast(dynamic value)
        {
            return new Context(value.GOARCH, value.GOOS, value.GOROOT, value.GOPATH, value.CgoEnabled, value.UseAllFiles, value.Compiler, value.BuildTags, value.ToolTags, value.ReleaseTags, value.InstallSuffix);
        }
    }
}}}}