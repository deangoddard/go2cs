//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Config
        {
            // Constructors
            public Config(NilType _)
            {
                this.goVersion = default;
                this.IgnoreFuncBodies = default;
                this.FakeImportC = default;
                this.go115UsesCgo = default;
                this.Error = default;
                this.Importer = default;
                this.Sizes = default;
                this.DisableUnusedImportCheck = default;
            }

            public Config(@string goVersion = default, bool IgnoreFuncBodies = default, bool FakeImportC = default, bool go115UsesCgo = default, Action<error> Error = default, Importer Importer = default, Sizes Sizes = default, bool DisableUnusedImportCheck = default)
            {
                this.goVersion = goVersion;
                this.IgnoreFuncBodies = IgnoreFuncBodies;
                this.FakeImportC = FakeImportC;
                this.go115UsesCgo = go115UsesCgo;
                this.Error = Error;
                this.Importer = Importer;
                this.Sizes = Sizes;
                this.DisableUnusedImportCheck = DisableUnusedImportCheck;
            }

            // Enable comparisons between nil and Config struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Config value, NilType nil) => value.Equals(default(Config));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Config value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Config value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Config value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Config(NilType nil) => default(Config);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Config Config_cast(dynamic value)
        {
            return new Config(value.goVersion, value.IgnoreFuncBodies, value.FakeImportC, value.go115UsesCgo, value.Error, value.Importer, value.Sizes, value.DisableUnusedImportCheck);
        }
    }
}}