//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:40 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BlkpgPartition
        {
            // Constructors
            public BlkpgPartition(NilType _)
            {
                this.Start = default;
                this.Length = default;
                this.Pno = default;
                this.Devname = default;
                this.Volname = default;
                this._ = default;
            }

            public BlkpgPartition(long Start = default, long Length = default, int Pno = default, array<byte> Devname = default, array<byte> Volname = default, array<byte> _ = default)
            {
                this.Start = Start;
                this.Length = Length;
                this.Pno = Pno;
                this.Devname = Devname;
                this.Volname = Volname;
                this._ = _;
            }

            // Enable comparisons between nil and BlkpgPartition struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BlkpgPartition value, NilType nil) => value.Equals(default(BlkpgPartition));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BlkpgPartition value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BlkpgPartition value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BlkpgPartition value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BlkpgPartition(NilType nil) => default(BlkpgPartition);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BlkpgPartition BlkpgPartition_cast(dynamic value)
        {
            return new BlkpgPartition(value.Start, value.Length, value.Pno, value.Devname, value.Volname, value._);
        }
    }
}}}}}}