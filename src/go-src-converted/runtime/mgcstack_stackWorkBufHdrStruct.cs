//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stackWorkBufHdr
        {
            // Constructors
            public stackWorkBufHdr(NilType _)
            {
                this.workbufhdr = default;
                this.next = default;
            }

            public stackWorkBufHdr(workbufhdr workbufhdr = default, ref ptr<stackWorkBuf> next = default)
            {
                this.workbufhdr = workbufhdr;
                this.next = next;
            }

            // Enable comparisons between nil and stackWorkBufHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackWorkBufHdr value, NilType nil) => value.Equals(default(stackWorkBufHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackWorkBufHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackWorkBufHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackWorkBufHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackWorkBufHdr(NilType nil) => default(stackWorkBufHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stackWorkBufHdr stackWorkBufHdr_cast(dynamic value)
        {
            return new stackWorkBufHdr(value.workbufhdr, ref value.next);
        }
    }
}