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
        public partial struct ENUM_SERVICE_STATUS_PROCESS
        {
            // Constructors
            public ENUM_SERVICE_STATUS_PROCESS(NilType _)
            {
                this.ServiceName = default;
                this.DisplayName = default;
                this.ServiceStatusProcess = default;
            }

            public ENUM_SERVICE_STATUS_PROCESS(ref ptr<ushort> ServiceName = default, ref ptr<ushort> DisplayName = default, SERVICE_STATUS_PROCESS ServiceStatusProcess = default)
            {
                this.ServiceName = ServiceName;
                this.DisplayName = DisplayName;
                this.ServiceStatusProcess = ServiceStatusProcess;
            }

            // Enable comparisons between nil and ENUM_SERVICE_STATUS_PROCESS struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ENUM_SERVICE_STATUS_PROCESS value, NilType nil) => value.Equals(default(ENUM_SERVICE_STATUS_PROCESS));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ENUM_SERVICE_STATUS_PROCESS value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ENUM_SERVICE_STATUS_PROCESS value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ENUM_SERVICE_STATUS_PROCESS value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ENUM_SERVICE_STATUS_PROCESS(NilType nil) => default(ENUM_SERVICE_STATUS_PROCESS);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ENUM_SERVICE_STATUS_PROCESS ENUM_SERVICE_STATUS_PROCESS_cast(dynamic value)
        {
            return new ENUM_SERVICE_STATUS_PROCESS(ref value.ServiceName, ref value.DisplayName, value.ServiceStatusProcess);
        }
    }
}}}}}}