//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:37:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct goFPInfo
        {
            // Constructors
            public goFPInfo(NilType _)
            {
                this.op = default;
                this.transArgs = default;
                this.gnuName = default;
                this.goName = default;
            }

            public goFPInfo(Op op = default, slice<nint> transArgs = default, @string gnuName = default, @string goName = default)
            {
                this.op = op;
                this.transArgs = transArgs;
                this.gnuName = gnuName;
                this.goName = goName;
            }

            // Enable comparisons between nil and goFPInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(goFPInfo value, NilType nil) => value.Equals(default(goFPInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(goFPInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, goFPInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, goFPInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator goFPInfo(NilType nil) => default(goFPInfo);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static goFPInfo goFPInfo_cast(dynamic value)
        {
            return new goFPInfo(value.op, value.transArgs, value.gnuName, value.goName);
        }
    }
}}}}}}}