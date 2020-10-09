//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct JOBOBJECT_BASIC_LIMIT_INFORMATION
        {
            // Constructors
            public JOBOBJECT_BASIC_LIMIT_INFORMATION(NilType _)
            {
                this.PerProcessUserTimeLimit = default;
                this.PerJobUserTimeLimit = default;
                this.LimitFlags = default;
                this.MinimumWorkingSetSize = default;
                this.MaximumWorkingSetSize = default;
                this.ActiveProcessLimit = default;
                this.Affinity = default;
                this.PriorityClass = default;
                this.SchedulingClass = default;
            }

            public JOBOBJECT_BASIC_LIMIT_INFORMATION(long PerProcessUserTimeLimit = default, long PerJobUserTimeLimit = default, uint LimitFlags = default, System.UIntPtr MinimumWorkingSetSize = default, System.UIntPtr MaximumWorkingSetSize = default, uint ActiveProcessLimit = default, System.UIntPtr Affinity = default, uint PriorityClass = default, uint SchedulingClass = default)
            {
                this.PerProcessUserTimeLimit = PerProcessUserTimeLimit;
                this.PerJobUserTimeLimit = PerJobUserTimeLimit;
                this.LimitFlags = LimitFlags;
                this.MinimumWorkingSetSize = MinimumWorkingSetSize;
                this.MaximumWorkingSetSize = MaximumWorkingSetSize;
                this.ActiveProcessLimit = ActiveProcessLimit;
                this.Affinity = Affinity;
                this.PriorityClass = PriorityClass;
                this.SchedulingClass = SchedulingClass;
            }

            // Enable comparisons between nil and JOBOBJECT_BASIC_LIMIT_INFORMATION struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(JOBOBJECT_BASIC_LIMIT_INFORMATION value, NilType nil) => value.Equals(default(JOBOBJECT_BASIC_LIMIT_INFORMATION));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(JOBOBJECT_BASIC_LIMIT_INFORMATION value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, JOBOBJECT_BASIC_LIMIT_INFORMATION value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, JOBOBJECT_BASIC_LIMIT_INFORMATION value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator JOBOBJECT_BASIC_LIMIT_INFORMATION(NilType nil) => default(JOBOBJECT_BASIC_LIMIT_INFORMATION);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static JOBOBJECT_BASIC_LIMIT_INFORMATION JOBOBJECT_BASIC_LIMIT_INFORMATION_cast(dynamic value)
        {
            return new JOBOBJECT_BASIC_LIMIT_INFORMATION(value.PerProcessUserTimeLimit, value.PerJobUserTimeLimit, value.LimitFlags, value.MinimumWorkingSetSize, value.MaximumWorkingSetSize, value.ActiveProcessLimit, value.Affinity, value.PriorityClass, value.SchedulingClass);
        }
    }
}}}}}}