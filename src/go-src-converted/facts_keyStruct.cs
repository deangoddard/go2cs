//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:28 UTC
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
        private partial struct key
        {
            // Constructors
            public key(NilType _)
            {
                this.pkg = default;
                this.obj = default;
                this.t = default;
            }

            public key(ref ptr<types.Package> pkg = default, types.Object obj = default, reflect.Type t = default)
            {
                this.pkg = pkg;
                this.obj = obj;
                this.t = t;
            }

            // Enable comparisons between nil and key struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(key value, NilType nil) => value.Equals(default(key));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(key value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, key value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, key value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator key(NilType nil) => default(key);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static key key_cast(dynamic value)
        {
            return new key(ref value.pkg, value.obj, value.t);
        }
    }
}}}}}}}