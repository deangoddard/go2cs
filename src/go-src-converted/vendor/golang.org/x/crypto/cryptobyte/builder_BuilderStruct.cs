//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:36:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class cryptobyte_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Builder
        {
            // Constructors
            public Builder(NilType _)
            {
                this.err = default;
                this.result = default;
                this.fixedSize = default;
                this.child = default;
                this.offset = default;
                this.pendingLenLen = default;
                this.pendingIsASN1 = default;
                this.inContinuation = default;
            }

            public Builder(error err = default, slice<byte> result = default, bool fixedSize = default, ref ptr<Builder> child = default, nint offset = default, nint pendingLenLen = default, bool pendingIsASN1 = default, ref ptr<bool> inContinuation = default)
            {
                this.err = err;
                this.result = result;
                this.fixedSize = fixedSize;
                this.child = child;
                this.offset = offset;
                this.pendingLenLen = pendingLenLen;
                this.pendingIsASN1 = pendingIsASN1;
                this.inContinuation = inContinuation;
            }

            // Enable comparisons between nil and Builder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Builder value, NilType nil) => value.Equals(default(Builder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Builder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Builder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Builder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Builder(NilType nil) => default(Builder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Builder Builder_cast(dynamic value)
        {
            return new Builder(value.err, value.result, value.fixedSize, ref value.child, value.offset, value.pendingLenLen, value.pendingIsASN1, ref value.inContinuation);
        }
    }
}}}}}