//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:13:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace @internal {
namespace syscall
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct REPARSE_DATA_BUFFER
        {
            // Constructors
            public REPARSE_DATA_BUFFER(NilType _)
            {
                this.ReparseTag = default;
                this.ReparseDataLength = default;
                this.Reserved = default;
                this.DUMMYUNIONNAME = default;
            }

            public REPARSE_DATA_BUFFER(uint ReparseTag = default, ushort ReparseDataLength = default, ushort Reserved = default, byte DUMMYUNIONNAME = default)
            {
                this.ReparseTag = ReparseTag;
                this.ReparseDataLength = ReparseDataLength;
                this.Reserved = Reserved;
                this.DUMMYUNIONNAME = DUMMYUNIONNAME;
            }

            // Enable comparisons between nil and REPARSE_DATA_BUFFER struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(REPARSE_DATA_BUFFER value, NilType nil) => value.Equals(default(REPARSE_DATA_BUFFER));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(REPARSE_DATA_BUFFER value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, REPARSE_DATA_BUFFER value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, REPARSE_DATA_BUFFER value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator REPARSE_DATA_BUFFER(NilType nil) => default(REPARSE_DATA_BUFFER);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static REPARSE_DATA_BUFFER REPARSE_DATA_BUFFER_cast(dynamic value)
        {
            return new REPARSE_DATA_BUFFER(value.ReparseTag, value.ReparseDataLength, value.Reserved, value.DUMMYUNIONNAME);
        }
    }
}}}