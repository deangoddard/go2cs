//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:34:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using gob = go.encoding.gob_package;
using fmt = go.fmt_package;
using types = go.go.types_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using sync = go.sync_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using objectpath = go.golang.org.x.tools.go.types.objectpath_package;
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
namespace @internal
{
    public static partial class facts_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Set
        {
            // Constructors
            public Set(NilType _)
            {
                this.pkg = default;
                this.mu = default;
                this.m = default;
            }

            public Set(ref ptr<types.Package> pkg = default, sync.Mutex mu = default, map<key, analysis.Fact> m = default)
            {
                this.pkg = pkg;
                this.mu = mu;
                this.m = m;
            }

            // Enable comparisons between nil and Set struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Set value, NilType nil) => value.Equals(default(Set));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Set value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Set value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Set value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Set(NilType nil) => default(Set);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Set Set_cast(dynamic value)
        {
            return new Set(ref value.pkg, value.mu, value.m);
        }
    }
}}}}}}}}}