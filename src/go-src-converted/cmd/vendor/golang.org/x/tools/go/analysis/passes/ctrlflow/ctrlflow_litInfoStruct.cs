//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:34:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ast = go.go.ast_package;
using types = go.go.types_package;
using log = go.log_package;
using reflect = go.reflect_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using inspect = go.golang.org.x.tools.go.analysis.passes.inspect_package;
using inspector = go.golang.org.x.tools.go.ast.inspector_package;
using cfg = go.golang.org.x.tools.go.cfg_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class ctrlflow_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct litInfo
        {
            // Constructors
            public litInfo(NilType _)
            {
                this.cfg = default;
                this.noReturn = default;
            }

            public litInfo(ref ptr<cfg.CFG> cfg = default, bool noReturn = default)
            {
                this.cfg = cfg;
                this.noReturn = noReturn;
            }

            // Enable comparisons between nil and litInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(litInfo value, NilType nil) => value.Equals(default(litInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(litInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, litInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, litInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator litInfo(NilType nil) => default(litInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static litInfo litInfo_cast(dynamic value)
        {
            return new litInfo(ref value.cfg, value.noReturn);
        }
    }
}}}}}}}}}