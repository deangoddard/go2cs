//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:34 UTC
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
        public partial struct HDDriveCmdHdr
        {
            // Constructors
            public HDDriveCmdHdr(NilType _)
            {
                this.Command = default;
                this.Number = default;
                this.Feature = default;
                this.Count = default;
            }

            public HDDriveCmdHdr(byte Command = default, byte Number = default, byte Feature = default, byte Count = default)
            {
                this.Command = Command;
                this.Number = Number;
                this.Feature = Feature;
                this.Count = Count;
            }

            // Enable comparisons between nil and HDDriveCmdHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HDDriveCmdHdr value, NilType nil) => value.Equals(default(HDDriveCmdHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HDDriveCmdHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HDDriveCmdHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HDDriveCmdHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HDDriveCmdHdr(NilType nil) => default(HDDriveCmdHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static HDDriveCmdHdr HDDriveCmdHdr_cast(dynamic value)
        {
            return new HDDriveCmdHdr(value.Command, value.Number, value.Feature, value.Count);
        }
    }
}}}}}}