//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:42 UTC
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
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TruncatableString
        {
            // Constructors
            public TruncatableString(NilType _)
            {
                this.Value = default;
                this.TruncatedByteCount = default;
            }

            public TruncatableString(@string Value = default, int TruncatedByteCount = default)
            {
                this.Value = Value;
                this.TruncatedByteCount = TruncatedByteCount;
            }

            // Enable comparisons between nil and TruncatableString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TruncatableString value, NilType nil) => value.Equals(default(TruncatableString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TruncatableString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TruncatableString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TruncatableString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TruncatableString(NilType nil) => default(TruncatableString);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TruncatableString TruncatableString_cast(dynamic value)
        {
            return new TruncatableString(value.Value, value.TruncatedByteCount);
        }
    }
}}}}}}}}