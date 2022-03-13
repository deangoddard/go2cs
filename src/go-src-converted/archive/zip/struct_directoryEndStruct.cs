//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fs = go.io.fs_package;
using path = go.path_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct directoryEnd
        {
            // Constructors
            public directoryEnd(NilType _)
            {
                this.diskNbr = default;
                this.dirDiskNbr = default;
                this.dirRecordsThisDisk = default;
                this.directoryRecords = default;
                this.directorySize = default;
                this.directoryOffset = default;
                this.commentLen = default;
                this.comment = default;
            }

            public directoryEnd(uint diskNbr = default, uint dirDiskNbr = default, ulong dirRecordsThisDisk = default, ulong directoryRecords = default, ulong directorySize = default, ulong directoryOffset = default, ushort commentLen = default, @string comment = default)
            {
                this.diskNbr = diskNbr;
                this.dirDiskNbr = dirDiskNbr;
                this.dirRecordsThisDisk = dirRecordsThisDisk;
                this.directoryRecords = directoryRecords;
                this.directorySize = directorySize;
                this.directoryOffset = directoryOffset;
                this.commentLen = commentLen;
                this.comment = comment;
            }

            // Enable comparisons between nil and directoryEnd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(directoryEnd value, NilType nil) => value.Equals(default(directoryEnd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(directoryEnd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, directoryEnd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, directoryEnd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator directoryEnd(NilType nil) => default(directoryEnd);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static directoryEnd directoryEnd_cast(dynamic value)
        {
            return new directoryEnd(value.diskNbr, value.dirDiskNbr, value.dirRecordsThisDisk, value.directoryRecords, value.directorySize, value.directoryOffset, value.commentLen, value.comment);
        }
    }
}}