//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:28 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct SERVICE_DELAYED_AUTO_START_INFO
        {
            // Constructors
            public SERVICE_DELAYED_AUTO_START_INFO(NilType _)
            {
                this.IsDelayedAutoStartUp = default;
            }

            public SERVICE_DELAYED_AUTO_START_INFO(uint IsDelayedAutoStartUp = default)
            {
                this.IsDelayedAutoStartUp = IsDelayedAutoStartUp;
            }

            // Enable comparisons between nil and SERVICE_DELAYED_AUTO_START_INFO struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SERVICE_DELAYED_AUTO_START_INFO value, NilType nil) => value.Equals(default(SERVICE_DELAYED_AUTO_START_INFO));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SERVICE_DELAYED_AUTO_START_INFO value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SERVICE_DELAYED_AUTO_START_INFO value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SERVICE_DELAYED_AUTO_START_INFO value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SERVICE_DELAYED_AUTO_START_INFO(NilType nil) => default(SERVICE_DELAYED_AUTO_START_INFO);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static SERVICE_DELAYED_AUTO_START_INFO SERVICE_DELAYED_AUTO_START_INFO_cast(dynamic value)
        {
            return new SERVICE_DELAYED_AUTO_START_INFO(value.IsDelayedAutoStartUp);
        }
    }
}}}}}}