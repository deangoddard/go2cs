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
using static go.builtin;
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
        public partial struct SecurityAttributes
        {
            // Constructors
            public SecurityAttributes(NilType _)
            {
                this.Length = default;
                this.SecurityDescriptor = default;
                this.InheritHandle = default;
            }

            public SecurityAttributes(uint Length = default, ref ptr<SECURITY_DESCRIPTOR> SecurityDescriptor = default, uint InheritHandle = default)
            {
                this.Length = Length;
                this.SecurityDescriptor = SecurityDescriptor;
                this.InheritHandle = InheritHandle;
            }

            // Enable comparisons between nil and SecurityAttributes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SecurityAttributes value, NilType nil) => value.Equals(default(SecurityAttributes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SecurityAttributes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SecurityAttributes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SecurityAttributes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SecurityAttributes(NilType nil) => default(SecurityAttributes);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SecurityAttributes SecurityAttributes_cast(dynamic value)
        {
            return new SecurityAttributes(value.Length, ref value.SecurityDescriptor, value.InheritHandle);
        }
    }
}}}}}}