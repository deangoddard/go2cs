//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct gcWork
        {
            // Constructors
            public gcWork(NilType _)
            {
                this.wbuf1 = default;
                this.wbuf2 = default;
                this.bytesMarked = default;
                this.scanWork = default;
                this.flushedWork = default;
            }

            public gcWork(ref ptr<workbuf> wbuf1 = default, ref ptr<workbuf> wbuf2 = default, ulong bytesMarked = default, long scanWork = default, bool flushedWork = default)
            {
                this.wbuf1 = wbuf1;
                this.wbuf2 = wbuf2;
                this.bytesMarked = bytesMarked;
                this.scanWork = scanWork;
                this.flushedWork = flushedWork;
            }

            // Enable comparisons between nil and gcWork struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcWork value, NilType nil) => value.Equals(default(gcWork));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcWork value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcWork value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcWork value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcWork(NilType nil) => default(gcWork);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static gcWork gcWork_cast(dynamic value)
        {
            return new gcWork(ref value.wbuf1, ref value.wbuf2, value.bytesMarked, value.scanWork, value.flushedWork);
        }
    }
}