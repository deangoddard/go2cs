//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using flag = go.flag_package;
using fmt = go.fmt_package;
using os = go.os_package;
using runtime = go.runtime_package;
using pprof = go.runtime.pprof_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InternalTest
        {
            // Constructors
            public InternalTest(NilType _)
            {
                this.Name = default;
                this.F = default;
            }

            public InternalTest(@string Name = default, Action<ptr<T>> F = default)
            {
                this.Name = Name;
                this.F = F;
            }

            // Enable comparisons between nil and InternalTest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InternalTest value, NilType nil) => value.Equals(default(InternalTest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InternalTest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InternalTest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InternalTest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InternalTest(NilType nil) => default(InternalTest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InternalTest InternalTest_cast(dynamic value)
        {
            return new InternalTest(value.Name, value.F);
        }
    }
}}