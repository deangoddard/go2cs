//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IO_STATUS_BLOCK
        {
            // Constructors
            public IO_STATUS_BLOCK(NilType _)
            {
                this.Status = default;
                this.Information = default;
            }

            public IO_STATUS_BLOCK(NTStatus Status = default, System.UIntPtr Information = default)
            {
                this.Status = Status;
                this.Information = Information;
            }

            // Enable comparisons between nil and IO_STATUS_BLOCK struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IO_STATUS_BLOCK value, NilType nil) => value.Equals(default(IO_STATUS_BLOCK));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IO_STATUS_BLOCK value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IO_STATUS_BLOCK value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IO_STATUS_BLOCK value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IO_STATUS_BLOCK(NilType nil) => default(IO_STATUS_BLOCK);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IO_STATUS_BLOCK IO_STATUS_BLOCK_cast(dynamic value)
        {
            return new IO_STATUS_BLOCK(value.Status, value.Information);
        }
    }
}}}}}}