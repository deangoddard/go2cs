//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:37 UTC
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
        public partial struct TIPCSubscr
        {
            // Constructors
            public TIPCSubscr(NilType _)
            {
                this.Seq = default;
                this.Timeout = default;
                this.Filter = default;
                this.Handle = default;
            }

            public TIPCSubscr(TIPCServiceRange Seq = default, uint Timeout = default, uint Filter = default, array<sbyte> Handle = default)
            {
                this.Seq = Seq;
                this.Timeout = Timeout;
                this.Filter = Filter;
                this.Handle = Handle;
            }

            // Enable comparisons between nil and TIPCSubscr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TIPCSubscr value, NilType nil) => value.Equals(default(TIPCSubscr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TIPCSubscr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TIPCSubscr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TIPCSubscr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TIPCSubscr(NilType nil) => default(TIPCSubscr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TIPCSubscr TIPCSubscr_cast(dynamic value)
        {
            return new TIPCSubscr(value.Seq, value.Timeout, value.Filter, value.Handle);
        }
    }
}}}}}}