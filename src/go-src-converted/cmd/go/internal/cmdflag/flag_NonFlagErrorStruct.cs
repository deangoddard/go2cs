//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:17:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class cmdflag_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NonFlagError
        {
            // Constructors
            public NonFlagError(NilType _)
            {
                this.RawArg = default;
            }

            public NonFlagError(@string RawArg = default)
            {
                this.RawArg = RawArg;
            }

            // Enable comparisons between nil and NonFlagError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NonFlagError value, NilType nil) => value.Equals(default(NonFlagError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NonFlagError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NonFlagError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NonFlagError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NonFlagError(NilType nil) => default(NonFlagError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NonFlagError NonFlagError_cast(dynamic value)
        {
            return new NonFlagError(value.RawArg);
        }
    }
}}}}