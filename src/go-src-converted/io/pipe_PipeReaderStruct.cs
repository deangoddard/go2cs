//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class io_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct PipeReader
        {
            // Constructors
            public PipeReader(NilType _)
            {
                this.p = default;
            }

            public PipeReader(ref ptr<pipe> p = default)
            {
                this.p = p;
            }

            // Enable comparisons between nil and PipeReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PipeReader value, NilType nil) => value.Equals(default(PipeReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PipeReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PipeReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PipeReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PipeReader(NilType nil) => default(PipeReader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PipeReader PipeReader_cast(dynamic value)
        {
            return new PipeReader(ref value.p);
        }
    }
}