//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fakeFileSet
        {
            // Constructors
            public fakeFileSet(NilType _)
            {
                this.fset = default;
                this.files = default;
            }

            public fakeFileSet(ref ptr<token.FileSet> fset = default, map<@string, ptr<token.File>> files = default)
            {
                this.fset = fset;
                this.files = files;
            }

            // Enable comparisons between nil and fakeFileSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fakeFileSet value, NilType nil) => value.Equals(default(fakeFileSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fakeFileSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fakeFileSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fakeFileSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fakeFileSet(NilType nil) => default(fakeFileSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fakeFileSet fakeFileSet_cast(dynamic value)
        {
            return new fakeFileSet(ref value.fset, value.files);
        }
    }
}}}