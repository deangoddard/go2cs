//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:42 UTC
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
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export {
namespace ocagent
{
    public static partial class wire_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ProcessIdentifier
        {
            // Constructors
            public ProcessIdentifier(NilType _)
            {
                this.HostName = default;
                this.Pid = default;
                this.StartTimestamp = default;
            }

            public ProcessIdentifier(@string HostName = default, uint Pid = default, Timestamp StartTimestamp = default)
            {
                this.HostName = HostName;
                this.Pid = Pid;
                this.StartTimestamp = StartTimestamp;
            }

            // Enable comparisons between nil and ProcessIdentifier struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ProcessIdentifier value, NilType nil) => value.Equals(default(ProcessIdentifier));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ProcessIdentifier value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ProcessIdentifier value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ProcessIdentifier value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProcessIdentifier(NilType nil) => default(ProcessIdentifier);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ProcessIdentifier ProcessIdentifier_cast(dynamic value)
        {
            return new ProcessIdentifier(value.HostName, value.Pid, value.StartTimestamp);
        }
    }
}}}}}}}}