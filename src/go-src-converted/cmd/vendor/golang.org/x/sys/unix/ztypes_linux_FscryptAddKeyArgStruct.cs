//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FscryptAddKeyArg
        {
            // Constructors
            public FscryptAddKeyArg(NilType _)
            {
                this.Key_spec = default;
                this.Raw_size = default;
                this.Key_id = default;
                this._ = default;
            }

            public FscryptAddKeyArg(FscryptKeySpecifier Key_spec = default, uint Raw_size = default, uint Key_id = default, array<uint> _ = default)
            {
                this.Key_spec = Key_spec;
                this.Raw_size = Raw_size;
                this.Key_id = Key_id;
                this._ = _;
            }

            // Enable comparisons between nil and FscryptAddKeyArg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FscryptAddKeyArg value, NilType nil) => value.Equals(default(FscryptAddKeyArg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FscryptAddKeyArg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FscryptAddKeyArg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FscryptAddKeyArg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FscryptAddKeyArg(NilType nil) => default(FscryptAddKeyArg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FscryptAddKeyArg FscryptAddKeyArg_cast(dynamic value)
        {
            return new FscryptAddKeyArg(value.Key_spec, value.Raw_size, value.Key_id, value._);
        }
    }
}}}}}}