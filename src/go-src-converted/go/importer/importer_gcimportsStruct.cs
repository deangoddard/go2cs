//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using build = go.go.build_package;
using gccgoimporter = go.go.@internal.gccgoimporter_package;
using gcimporter = go.go.@internal.gcimporter_package;
using srcimporter = go.go.@internal.srcimporter_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using runtime = go.runtime_package;
using go;

namespace go {
namespace go
{
    public static partial class importer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcimports
        {
            // Constructors
            public gcimports(NilType _)
            {
                this.packages = default;
                this.lookup = default;
            }

            public gcimports(map<@string, ref types.Package> packages = default, Lookup lookup = default)
            {
                this.packages = packages;
                this.lookup = lookup;
            }

            // Enable comparisons between nil and gcimports struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcimports value, NilType nil) => value.Equals(default(gcimports));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcimports value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcimports value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcimports value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcimports(NilType nil) => default(gcimports);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gcimports gcimports_cast(dynamic value)
        {
            return new gcimports(value.packages, value.lookup);
        }
    }
}}