//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:52 UTC
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SERVICE_TABLE_ENTRY
        {
            // Constructors
            public SERVICE_TABLE_ENTRY(NilType _)
            {
                this.ServiceName = default;
                this.ServiceProc = default;
            }

            public SERVICE_TABLE_ENTRY(ref ptr<ushort> ServiceName = default, System.UIntPtr ServiceProc = default)
            {
                this.ServiceName = ServiceName;
                this.ServiceProc = ServiceProc;
            }

            // Enable comparisons between nil and SERVICE_TABLE_ENTRY struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SERVICE_TABLE_ENTRY value, NilType nil) => value.Equals(default(SERVICE_TABLE_ENTRY));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SERVICE_TABLE_ENTRY value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SERVICE_TABLE_ENTRY value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SERVICE_TABLE_ENTRY value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SERVICE_TABLE_ENTRY(NilType nil) => default(SERVICE_TABLE_ENTRY);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SERVICE_TABLE_ENTRY SERVICE_TABLE_ENTRY_cast(dynamic value)
        {
            return new SERVICE_TABLE_ENTRY(ref value.ServiceName, value.ServiceProc);
        }
    }
}}}}}}